using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PegasusExportPlugin.Properties;
using Unbroken.LaunchBox.Plugins;
using Unbroken.LaunchBox.Plugins.Data;

namespace PegasusExportPlugin
{
    public partial class frmPegasusExport : Form, ISystemMenuItemPlugin
    {
        public frmPegasusExport()
        {
            InitializeComponent();
        }

        public string Caption => "Pegasus Export";

        public Image IconImage => Resources.favicon96;

        public bool ShowInLaunchBox => true;

        public bool ShowInBigBox => false;

        public bool AllowInBigBoxWhenLocked => false;

        public void OnSelected()
        {
            this.Show();
        }

        private async void BtnExport_Click(object sender, System.EventArgs e)
        {
            if(!chkAssets.Checked && !chkRoms.Checked && !chkMetaData.Checked)
            {
                MessageBox.Show("Please select at least one item to export.");
                return;
            }

            var selectedFolder = fbdExportFolder.SelectedPath;

            if (string.IsNullOrWhiteSpace(selectedFolder) ||  !Directory.Exists(selectedFolder))
            {
                MessageBox.Show("Please select a valid location.");
                return;
            }
            
            progressBar.Value = 0;
            await Task.Run(() => {
                int progress = 0;
                var dataManager = PluginHelper.DataManager;
                var games = dataManager.GetAllGames();
                var numberOfGames = games.Length;
                var gamesByPlatform = games.GroupBy(game => game.Platform);

                foreach (var gamePlatform in gamesByPlatform)
                {
                    var platformFolderName = Unbroken.FileHelper.CoerceValidFileName(gamesByPlatform.First().Key);
                    var platformPath = Path.Combine(selectedFolder, platformFolderName);
                    Directory.CreateDirectory(platformPath);
                    var stringBuilder = new StringBuilder();

                    foreach (var game in gamePlatform)
                    {
                        progress++;
                        BeginInvoke(new MethodInvoker(() => { progressBar.Value = (int)(((double)progress / (double)numberOfGames) * 100); }));

                        if(chkMetaData.Checked)
                        {
                            if(string.IsNullOrWhiteSpace(game.Title))
                            {
                                continue;
                            }
                            stringBuilder.AppendLine($"game: {game.Title}");

                            if (!string.IsNullOrWhiteSpace(game.ApplicationPath))
                            {
                                var file = Path.GetFileName(game.ApplicationPath);
                                stringBuilder.AppendLine($"file: {file}");
                            }

                            if (!string.IsNullOrWhiteSpace(game.Developer))
                            {
                                stringBuilder.AppendLine($"developer: {game.Developer}");
                            }

                            if (!string.IsNullOrWhiteSpace(game.Publisher))
                            {
                                stringBuilder.AppendLine($"publisher: {game.Publisher}");
                            }

                            foreach (var genre in game.Genres)
                            {
                                if (!string.IsNullOrWhiteSpace(genre))
                                {
                                    stringBuilder.AppendLine($"genre: {genre}");
                                }
                            }

                            if (!string.IsNullOrWhiteSpace(game.Notes))
                            {
                                stringBuilder.AppendLine($"description: {game.Notes}");
                            }

                            if (game.ReleaseDate != null)
                            {
                                stringBuilder.AppendLine($"release: {((DateTime)game.ReleaseDate).ToString("yyyy-MM-dd")}");
                            }

                            if (game.CommunityStarRatingTotalVotes > 0)
                            {
                                var rating = (int)((game.CommunityStarRating / (float)5) * 100);
                                stringBuilder.AppendLine($"rating: {rating}");
                            }

                            stringBuilder.AppendLine();
                        }

                        if(chkAssets.Checked)
                        {
                            var mediaFolder = Path.Combine(platformPath, "media", Path.GetFileNameWithoutExtension(game.ApplicationPath));
                            Directory.CreateDirectory(mediaFolder);

                            var images = game.GetAllImagesWithDetails();
                            foreach (var image in images)
                            {
                                if (!string.IsNullOrWhiteSpace(image.FilePath) && File.Exists(image.FilePath))
                                {
                                    if (image.ImageType == Unbroken.LaunchBox.Properties.Strings.ImageTypeBoxFront)
                                    {
                                        File.Copy(image.FilePath, Path.Combine(mediaFolder, "boxFront" + Path.GetExtension(image.FilePath)), true);
                                    }
                                    if (image.ImageType == Unbroken.LaunchBox.Properties.Strings.ImageTypeClearLogo)
                                    {
                                        File.Copy(image.FilePath, Path.Combine(mediaFolder, "logo" + Path.GetExtension(image.FilePath)), true);
                                    }
                                    if (image.ImageType == Unbroken.LaunchBox.Properties.Strings.ImageTypeFanartBackground)
                                    {
                                        File.Copy(image.FilePath, Path.Combine(mediaFolder, "background" + Path.GetExtension(image.FilePath)), true);
                                    }
                                }
                            }
                            var video = game.GetVideoPath(false);
                            if (!string.IsNullOrWhiteSpace(video) && File.Exists(video))
                            {
                                File.Copy(video, Path.Combine(mediaFolder, "video" + Path.GetExtension(video)), true);
                            }
                        }

                        if(chkRoms.Checked)
                        {
                            File.Copy(game.ApplicationPath, Path.Combine(platformPath, Path.GetFileName(game.ApplicationPath)), true); 
                        }
                        
                    }
                    if(chkMetaData.Checked)
                    {
                        File.WriteAllText(Path.Combine(platformPath, "metadata.pegasus.txt"), stringBuilder.ToString());
                    }
                }

            });
           

        }

        private void BtnBrowse_Click(object sender, System.EventArgs e)
        {
            if(fbdExportFolder.ShowDialog() == DialogResult.OK)
            {
                txtExportPath.Text = fbdExportFolder.SelectedPath;
            }
        }
    }
}
