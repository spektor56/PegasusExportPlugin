using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unbroken.LaunchBox.Plugins.Data;

namespace PegasusExportPlugin.Launchbox
{
    public class ImageDetail
    {
        public ImageDetail (ImageDetails imageDetails, double aspectRatio)
        {
            Image = imageDetails;
            AspectRatio = aspectRatio;
        }
        public ImageDetails Image { get; set; }
        public double AspectRatio { get; set; }
    }
}
