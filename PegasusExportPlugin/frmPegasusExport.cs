using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using PegasusExportPlugin.Controls;
using PegasusExportPlugin.Launchbox;
using PegasusExportPlugin.Pegasus;
using Unbroken;
using Unbroken.LaunchBox.Plugins;
using Unbroken.LaunchBox.Plugins.Data;
using Resources = PegasusExportPlugin.Properties.Resources;

namespace PegasusExportPlugin
{
    public partial class frmPegasusExport : Form, ISystemMenuItemPlugin
    {
        public frmPegasusExport()
        {
            InitializeComponent();
        }

        private IDataManager _dataManager = PluginHelper.DataManager;

        private Dictionary<string, string> _imageTypeDictionary = new Dictionary<string,string>();
        public string Caption => "Pegasus Export";

        public Image IconImage => Resources.favicon96;

        public bool ShowInLaunchBox => true;

        public bool ShowInBigBox => false;

        public bool AllowInBigBoxWhenLocked => false;

        public void OnSelected()
        {
            Show();
        }

        private async void BtnExport_Click(object sender, EventArgs e)
        {
            if (!chkAssets.Checked && !chkApplication.Checked && !chkMetaData.Checked)
            {
                MessageBox.Show("Please select at least one item to export.");
                return;
            }

            var selectedFolder = fbdExportFolder.SelectedPath;

            if (string.IsNullOrWhiteSpace(selectedFolder) || !Directory.Exists(selectedFolder))
            {
                MessageBox.Show("Please select a valid location.");
                return;
            }

            var selectedAssets = clbAssetList.CheckedItems;
            if (selectedAssets.Count < 1 && chkAssets.Checked)
            {
                MessageBox.Show("You selected to export assets but no assets are selected.");
                return;
            }

            var platformSettings = (BindingList<PlatformSetting>)dgvPlatforms.DataSource;
            var platformsToExport = platformSettings.Where(platform => platform.Selected && ((platform.ExportApplication && chkApplication.Checked) || (platform.ExportAssets && chkAssets.Checked) || (platform.ExportMetadata && chkMetaData.Checked))).ToArray();
            if(platformsToExport.Length < 1)
            {
                MessageBox.Show("You didn't select any platforms/data to export.");
                return;
            }
            
            btnExport.Enabled = false;

            try
            {
                bool exportAssets = chkAssets.Checked;
                bool exportMetadata = chkMetaData.Checked;
                bool exportApplication = chkApplication.Checked;
                bool copyAssets = radCopyAssets.Checked;
                bool copyApplication = radCopyApplication.Checked;
                bool assetsAbsolutePath = radAbsoluteAssets.Checked;
                bool applicationAbsolutePath = radAbsoluteApplication.Checked;

                progressBar.Value = 0;
                await Task.Run(() =>
                {
                    var progress = 0;

                    var platformList = new HashSet<string>(platformsToExport.Select(platform => platform.Name));
                    var platformAssetExportList = new HashSet<string> (platformsToExport.Where(platform => platform.ExportAssets).Select(platform => platform.Name));
                    var platformMetadataExportList = new HashSet<string>(platformsToExport.Where(platform => platform.ExportMetadata).Select(platform => platform.Name));
                    var platformApplicationExportList = new HashSet<string>(platformsToExport.Where(platform => platform.ExportApplication).Select(platform => platform.Name));

                    var games = _dataManager.GetAllGames().Where(game => platformList.Contains(game.Platform)).ToArray();
                    var numberOfGames = games.Length;
                    var gamesByPlatform = games.GroupBy(game => game.Platform);

                    Parallel.ForEach(gamesByPlatform, gamePlatform =>
                    {
                        var platform = gamePlatform.First().Platform;
                        var platformFolderName = FileHelper.CoerceValidFileName(platform);
                        var platformPath = Path.Combine(selectedFolder, platformFolderName);
                        Directory.CreateDirectory(platformPath);
                        var metadataBuilder = new StringBuilder();
                        metadataBuilder.AppendLine($"collection: {platform}");
                        var gamesMetadata = new Dictionary<IGame, StringBuilder>();
                        
                        var imageList = new Dictionary<string, Dictionary<IGame, List<ImageDetail>>>();

                        var fileExtensions = new HashSet<string>();

                        double boxFrontAspectRatioMode = 0;
                        var aspectRatioList = new Dictionary<double, int>();
                        int modeCount = 0;

                        foreach (var game in gamePlatform)
                        {
                            if ((exportMetadata  && platformMetadataExportList.Contains(platform)) || (exportAssets && platformAssetExportList.Contains(platform) && !copyAssets))
                            {
                                var gameMetadataBuilder = new StringBuilder();

                                if (!string.IsNullOrWhiteSpace(game.Title))
                                {
                                    gameMetadataBuilder.AppendLine($"game: {game.Title}");

                                    if (!string.IsNullOrWhiteSpace(game.ApplicationPath))
                                    {
                                        string file;
                                        if (copyApplication)
                                        {
                                            file = Path.GetFileName(game.ApplicationPath);
                                        }
                                        else
                                        {
                                            if(applicationAbsolutePath)
                                            {
                                                file = game.ApplicationPath;
                                            }
                                            else
                                            {
                                                file = game.ApplicationPath;
                                            }
                                            //var test = Path.GetRelativePath();
                                        }
                                        gameMetadataBuilder.AppendLine($"file: {file}");

                                        var fileExtension = Path.GetExtension(file).Replace(".", "");
                                        if (!fileExtensions.Contains(fileExtension))
                                        {
                                            fileExtensions.Add(fileExtension);
                                        }
                                    }

                                    if (!string.IsNullOrWhiteSpace(game.Developer))
                                    {
                                        gameMetadataBuilder.AppendLine($"developer: {game.Developer}");
                                    }

                                    if (!string.IsNullOrWhiteSpace(game.Publisher))
                                    {
                                        gameMetadataBuilder.AppendLine($"publisher: {game.Publisher}");
                                    }

                                    foreach (var genre in game.Genres)
                                    {
                                        if (!string.IsNullOrWhiteSpace(genre))
                                        {
                                            gameMetadataBuilder.AppendLine($"genre: {genre}");
                                        }
                                    }

                                    if (!string.IsNullOrWhiteSpace(game.Notes))
                                    {
                                        gameMetadataBuilder.AppendLine($"description: {game.Notes}");
                                    }

                                    if (game.ReleaseDate != null)
                                    {
                                        gameMetadataBuilder.AppendLine(
                                            $"release: {((DateTime)game.ReleaseDate).ToString("yyyy-MM-dd")}");
                                    }

                                    if (game.CommunityStarRatingTotalVotes > 0)
                                    {
                                        var rating = (int)(game.CommunityStarRating / 5 * 100);
                                        gameMetadataBuilder.AppendLine($"rating: {rating}");
                                    }
                                    gamesMetadata.Add(game, gameMetadataBuilder);
                                }
                            }

                            if (exportAssets && platformAssetExportList.Contains(platform))
                            {
                                var mediaFolder = Path.Combine(platformPath, "media",
                                    Path.GetFileNameWithoutExtension(game.ApplicationPath));
                                
                                var images = game.GetAllImagesWithDetails();

                                foreach (var image in images)
                                {
                                    if (!string.IsNullOrWhiteSpace(image.FilePath) && File.Exists(image.FilePath))
                                    {
                                        if (_imageTypeDictionary.ContainsKey(image.ImageType))
                                        {
                                            var pegasusImageType = _imageTypeDictionary[image.ImageType];
                                            if (selectedAssets.Contains(pegasusImageType))
                                            {
                                                if (!imageList.ContainsKey(pegasusImageType))
                                                {
                                                    imageList.Add(pegasusImageType,
                                                        new Dictionary<IGame, List<ImageDetail>>());
                                                }

                                                if (!imageList[pegasusImageType].ContainsKey(game))
                                                {
                                                    imageList[pegasusImageType].Add(game, new List<ImageDetail>());
                                                }

                                                double aspectRatio = 0;
                                                if (pegasusImageType == PegasusAssetType.BoxFront)
                                                {
                                                    using (var img = Image.FromFile(image.FilePath))
                                                    {
                                                        aspectRatio = (double)img.Height / (double)img.Width;
                                                    }

                                                    if(!aspectRatioList.ContainsKey(aspectRatio))
                                                    {
                                                        aspectRatioList.Add(aspectRatio, 0);
                                                    }

                                                    var count = ++aspectRatioList[aspectRatio];

                                                    if(count > modeCount)
                                                    {
                                                        modeCount = count;
                                                        boxFrontAspectRatioMode = aspectRatio;
                                                    }
                                                }
                                               
                                                imageList[pegasusImageType][game].Add(new ImageDetail(image, aspectRatio));
                                            }
                                        }
                                    }
                                }

                                //Export Videos
                                if(selectedAssets.Contains(PegasusAssetType.Video))
                                {
                                    var video = game.GetVideoPath();
                                    if (!string.IsNullOrWhiteSpace(video) && File.Exists(video))
                                    {
                                        if (copyAssets)
                                        {
                                            Directory.CreateDirectory(mediaFolder);
                                            File.Copy(video, Path.Combine(mediaFolder, PegasusAssetType.Video + Path.GetExtension(video)),
                                            true);
                                        }
                                        else
                                        {
                                            gamesMetadata[game].AppendLine($@"assets.{PegasusAssetType.Video}: {video}");
                                        }
                                    }
                                }
                            }

                            //Export Roms
                            if (copyApplication && exportApplication && platformApplicationExportList.Contains(platform))
                            {
                                if (!string.IsNullOrWhiteSpace(game.ApplicationPath) && File.Exists(game.ApplicationPath))
                                {
                                    File.Copy(game.ApplicationPath,
                                        Path.Combine(platformPath, Path.GetFileName(game.ApplicationPath)), true);
                                    var fileExtension = Path.GetExtension(game.ApplicationPath).Replace(".", "");
                                    if (!fileExtensions.Contains(fileExtension))
                                    {
                                        fileExtensions.Add(fileExtension);
                                    }
                                }
                            }                         

                            Interlocked.Increment(ref progress);

                            BeginInvoke(new MethodInvoker(() =>
                            {
                                progressBar.Value = (int)(progress / (double)numberOfGames * 100);
                            }));
                        }
                              
                        //Export Images
                        foreach (var imageType in imageList)
                        {
                            var pegasusImageType = imageType.Key;
                            foreach (var game in imageType.Value)
                            {
                                var mediaFolder = Path.Combine(platformPath, "media",
                                    Path.GetFileNameWithoutExtension(game.Key.ApplicationPath));

                                if (pegasusImageType == PegasusAssetType.BoxFront)
                                {
                                    ImageDetails bestImage = game.Value.First().Image;
                                    double? minDifference = null;
                                    foreach(var imageDetail in game.Value)
                                    {
                                        var difference = Math.Abs(boxFrontAspectRatioMode - imageDetail.AspectRatio);
                                        if(difference == 0)
                                        {
                                            bestImage = imageDetail.Image;
                                            break;
                                        }
                                        else
                                        {
                                            if(minDifference is null || difference < minDifference)
                                            {
                                                minDifference = difference;
                                                bestImage = imageDetail.Image;
                                            }
                                        }
                                    }
                                   
                                    if (copyAssets)
                                    {
                                        Directory.CreateDirectory(mediaFolder);
                                        File.Copy(bestImage.FilePath,
                                            Path.Combine(mediaFolder, pegasusImageType + Path.GetExtension(bestImage.FilePath)),
                                            true);
                                    }
                                    else
                                    {
                                        gamesMetadata[game.Key].AppendLine($@"assets.{pegasusImageType}: {bestImage.FilePath}");
                                    }
                                    
                                }
                                else
                                {
                                    var firstImage = game.Value.First().Image;
                                    if (copyAssets)
                                    {
                                        Directory.CreateDirectory(mediaFolder);
                                        File.Copy(firstImage.FilePath,
                                            Path.Combine(mediaFolder, pegasusImageType + Path.GetExtension(firstImage.FilePath)),
                                            true);
                                    }
                                    else
                                    {
                                        gamesMetadata[game.Key].AppendLine($@"assets.{pegasusImageType}: {firstImage.FilePath}");
                                    }
                                }
                            }
                        }

                        //Export Metadata
                        if ((exportMetadata && platformMetadataExportList.Contains(platform)) || (exportAssets && platformAssetExportList.Contains(platform) && !copyAssets))
                        {
                            if (fileExtensions.Count > 0)
                            {
                                metadataBuilder.AppendLine(string.Format(@"extensions: {0}",
                                    string.Join(", ", fileExtensions)));
                            }

                            metadataBuilder.AppendLine("");
                            metadataBuilder.AppendLine(string.Join(Environment.NewLine, gamesMetadata.Select(item => item.Value.ToString())));
                            File.WriteAllText(Path.Combine(platformPath, "metadata.pegasus.txt"), metadataBuilder.ToString());
                        }
                    });
                });
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                throw;
            }
            finally
            {
                btnExport.Enabled = true;
                progressBar.Value = 100;
            }
            
            MessageBox.Show("Done!");
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            if (fbdExportFolder.ShowDialog() == DialogResult.OK)
            {
                txtExportPath.Text = fbdExportFolder.SelectedPath;
            }
        }

        private void BtnUp_Click(object sender, EventArgs e)
        {
            var item = lbImagePriority.SelectedItem;
            if (item != null)
            {
                var newItemIndex = Math.Max(0, lbImagePriority.Items.IndexOf(item) - 1);
                lbImagePriority.Items.Remove(item);
                lbImagePriority.Items.Insert(newItemIndex, item);
                lbImagePriority.SelectedIndex = newItemIndex;
            }
        }

        private void BtnDown_Click(object sender, EventArgs e)
        {
            var item = lbImagePriority.SelectedItem;
            if (item != null)
            {
                var newItemIndex = Math.Min(lbImagePriority.Items.Count - 1, lbImagePriority.Items.IndexOf(item) + 1);
                lbImagePriority.Items.Remove(item);
                lbImagePriority.Items.Insert(newItemIndex, item);
                lbImagePriority.SelectedIndex = newItemIndex;
            }
        }

        private void FrmPegasusExport_Load(object sender, EventArgs e)
        {
            var translationTable = XElement.Load(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),"translationTable.xml"));

            var imageTypes = translationTable.Descendants("asset").Select(item =>  item);
            foreach (var imageType in imageTypes)
            {
                if (imageType.Element("key") != null && imageType.Element("value") != null &&
                            !string.IsNullOrWhiteSpace(imageType.Element("key").Value) &&
                            !string.IsNullOrWhiteSpace(imageType.Element("value").Value))
                {
                    _imageTypeDictionary.Add(imageType.Element("key").Value, imageType.Element("value").Value);
                    
                }
            }

            clbAssetList.DataSource = _imageTypeDictionary.Select(image => image.Value).Distinct().ToArray();
            for (int i = 0; i < clbAssetList.Items.Count; i++)
            {
                clbAssetList.SetItemChecked(i,true);
            }

            var platformList = new BindingList<Launchbox.PlatformSetting>(_dataManager.GetAllPlatforms().Select(platform => new Launchbox.PlatformSetting() { Name = platform.Name }).ToList());
            dgvPlatforms.AutoGenerateColumns = false;
            dgvPlatforms.DataSource = platformList;

            
            ((DataGridViewCheckBoxColumnHeaderCell)colSelected.HeaderCell).Select(true);

        }
    }
}