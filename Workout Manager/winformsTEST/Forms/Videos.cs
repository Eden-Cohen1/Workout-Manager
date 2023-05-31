using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using System.IO;
namespace winformsTEST.Forms
{
    public partial class Videos : UserControl
    {
        public Videos()
        {
            InitializeComponent();
            ControlExtension.Draggable(Shoulders, true);

        }

        private void VideoPlay(string filePath)
        {
            if (!string.IsNullOrEmpty(filePath) && File.Exists(filePath))
            {
                VideoPlayer.URL = filePath;
                VideoPlayer.Ctlcontrols.play();
                Mainform.instance.backgroundMusic.settings.mute = true;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            VideoPlay(@"Shoulder Press.mp4");
        }

        private void Tricep_Click(object sender, EventArgs e)
        {
            VideoPlay(@"Tricep Extension.mp4");
        }

        private void Chest_Click(object sender, EventArgs e)
        {
            VideoPlay(@"Chest.mp4");
        }

        private void Biceps_Click(object sender, EventArgs e)
        {
            VideoPlay(@"Bicep Curl.mp4");
        }

        private void LowerBack_Click(object sender, EventArgs e)
        {
            VideoPlay(@"Lower Back.mp4");
        }

        private void UpperBack_Click(object sender, EventArgs e)
        {
            VideoPlay(@"Upper Back.mp4");
        }

        private void Quads_Click(object sender, EventArgs e)
        {
            VideoPlay(@"Quads.mp4");
        }

        private void Hamstrings_Click(object sender, EventArgs e)
        {
            VideoPlay(@"Hamstrings.mp4");
        }
    }
}