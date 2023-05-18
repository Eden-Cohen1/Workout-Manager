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

    }

    private void button2_Click(object sender, EventArgs e)
        {
            string filePath = @"Shoulder Press.mp4";
            if (!string.IsNullOrEmpty(filePath) && File.Exists(filePath))
            {
                VideoPlayer.URL = filePath;
                VideoPlayer.Ctlcontrols.play();
                Mainform.instance.backgroundMusic.settings.mute = true;
            }
        }

        private void Tricep_Click(object sender, EventArgs e)
        {
            string filePath = @"Tricep Extension.mp4";
            if (!string.IsNullOrEmpty(filePath) && File.Exists(filePath))
            {
                VideoPlayer.URL = filePath;
                VideoPlayer.Ctlcontrols.play();
                Mainform.instance.backgroundMusic.settings.mute = true;
            }
        }

        private void Chest_Click(object sender, EventArgs e)
        {
            string filePath = @"Chest.mp4";
            if (!string.IsNullOrEmpty(filePath) && File.Exists(filePath))
            {
                VideoPlayer.URL = filePath;
                VideoPlayer.Ctlcontrols.play();
                Mainform.instance.backgroundMusic.settings.mute = true;
            }
        }

        private void Biceps_Click(object sender, EventArgs e)
        {
            string filePath = @"Bicep Curl.mp4";
            if (!string.IsNullOrEmpty(filePath) && File.Exists(filePath))
            {
                VideoPlayer.URL = filePath;
                VideoPlayer.Ctlcontrols.play();
                Mainform.instance.backgroundMusic.settings.mute = true;
            }
        }

        private void LowerBack_Click(object sender, EventArgs e)
        {
            string filePath = @"Lower Back.mp4";
            if (!string.IsNullOrEmpty(filePath) && File.Exists(filePath))
            {
                VideoPlayer.URL = filePath;
                VideoPlayer.Ctlcontrols.play();
                Mainform.instance.backgroundMusic.settings.mute = true;
            }
        }

        private void UpperBack_Click(object sender, EventArgs e)
        {
            string filePath = @"Upper Back.mp4";
            if (!string.IsNullOrEmpty(filePath) && File.Exists(filePath))
            {
                VideoPlayer.URL = filePath;
                VideoPlayer.Ctlcontrols.play();
                Mainform.instance.backgroundMusic.settings.mute = true;
            }
        }

        private void Quads_Click(object sender, EventArgs e)
        {
            string filePath = @"Quads.mp4";
            if (!string.IsNullOrEmpty(filePath) && File.Exists(filePath))
            {
                VideoPlayer.URL = filePath;
                VideoPlayer.Ctlcontrols.play();
                Mainform.instance.backgroundMusic.settings.mute = true;
            }
        }

        private void Hamstrings_Click(object sender, EventArgs e)
        {
            string filePath = @"Hamstrings.mp4";
            if (!string.IsNullOrEmpty(filePath) && File.Exists(filePath))
            {
                VideoPlayer.URL = filePath;
                VideoPlayer.Ctlcontrols.play();
                Mainform.instance.backgroundMusic.settings.mute = true;
            }
        }
    }
}