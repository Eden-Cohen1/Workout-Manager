using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MUSCLE;
using EXERCISE;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Runtime.InteropServices;
using System.Media;
using winformsTEST.Forms;
namespace winformsTEST
{

    public partial class Mainform : Form
    {
        public static Mainform instance;
        public static myWorkouts screen;
        public static AddWorkout screen2;
        public static SoundPlayer sPlayer = new SoundPlayer(@"button2.wav");
        public int soundOnFlag;
        public Mainform()
        {
            InitializeComponent();
            backMusic();
            soundOnFlag = 1;
            screen = new myWorkouts();
            screen2 = new AddWorkout();
            secPanel.AutoSize = true;
            instance = this;
            //loading workout list;
            foreach (Workout workout in AddWorkout.workout_list)
            {
                string type;
                if (workout.type == 1)
                {
                    type = "Strenght Workout";
                }
                else if (workout.type == 2)
                {
                    type = "Cardio Workout";

                }
                else
                {
                    type = "NO TYPE";
                }
                string name = workout._workoutName;
                string description = workout._Description;
                string duration = workout._Duration;
                string calories = workout._totalCalories.ToString();
                string[] listnames = { name, duration + " minutes", type, description,calories };
                var listviewitem = new ListViewItem(listnames);
                myWorkouts.instance.myWorkoutsList.Items.Add(listviewitem);
            }
        }

        private void backMusic()
        {
            backgroundMusic.URL = @"background-music.wav";
            backgroundMusic.settings.playCount = 9999;
            backgroundMusic.Visible = false;
            backgroundMusic.settings.volume = 20;
        }
        private void newWorkout_Click(object sender, EventArgs e)
        {
            sPlayer.Play();
            secPanel.Controls.Add(screen2);
            screen2.BringToFront();
            screen2.Size = secPanel.Size;
            AddWorkout.instance.workoutAdded.Visible = false;
            Headline.Text = "ADDING A NEW WORKOUT ";
            Headline.BackColor = Color.FromName("RoyalBlue");
            Minimize.BackColor = Color.FromName("RoyalBlue");
            topPanel.BackColor = Color.FromName("RoyalBlue");
            Exit.BackColor = Color.FromName("RoyalBlue");

        }

        private void myWorkouts_Click(object sender, EventArgs e)
        {
            sPlayer.Play();
            secPanel.Controls.Add(screen);
            screen.BringToFront();
            screen.Size = this.Size;
            Headline.Text = "MY WORKOUTS";
            Headline.BackColor = Color.FromName("RoyalBlue");
            Minimize.BackColor = Color.FromName("RoyalBlue");
            Exit.BackColor = Color.FromName("RoyalBlue");
            topPanel.BackColor = Color.FromName("RoyalBlue");
            
        }


        private void Home_Click(object sender, EventArgs e)
        {
            sPlayer.Play();
            secPanel.Controls.Add(background);
            background.BringToFront();
            Headline.Text = "HOME";
            Headline.BackColor = Color.FromArgb(28, 26, 33);
            Minimize.BackColor = Color.FromArgb(28, 26, 33);
            Exit.BackColor = Color.FromArgb(28, 26, 33);
            topPanel.BackColor = Color.FromArgb(28, 26, 33);
            

        }

        public static void blockBTN(UserControl win, Button btn)
        {
            foreach(TextBox txt in win.Controls)
            {
                if (txt.Text.Length == 0)
                {
                    btn.Enabled = false;
                }
                else
                {
                    btn.Enabled = true;
                }
            }
        }
        public static void blockBTN(Form win, Button btn)
        {
            foreach (Control txt in win.Controls)
            {
                if (txt is TextBox)
                {
                    if (txt.Text.Length == 0)
                    {
                        btn.Enabled = false;
                    }
                    else
                    {
                        btn.Enabled = true;
                    }
                }
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            sPlayer.Play();
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("main_file", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, AddWorkout.workout_list);
            stream.Close();
            this.Close();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            sPlayer.Play();
            this.WindowState = FormWindowState.Minimized;
        }

        private void Sound_Click(object sender, EventArgs e)
        {
            if(soundOnFlag == 1)
            {
                backgroundMusic.settings.mute = true;
                soundOnFlag = 0;
                Sound.Image = Image.FromFile(@"soundOFF.PNG");
            }
            else
            {
                backgroundMusic.settings.mute = false;
                soundOnFlag = 1;
                Sound.Image = Image.FromFile(@"soundON.PNG");

            }

        }

        private void Videos_Click(object sender, EventArgs e)
        {
            Videos videoPage = new Videos();
            sPlayer.Play();
            secPanel.Controls.Add(videoPage);
            videoPage.BringToFront();
            videoPage.Size = this.Size;
            Headline.Text = "VIDEO TUTURIALS";
            Headline.BackColor = Color.FromName("RoyalBlue");
            Minimize.BackColor = Color.FromName("RoyalBlue");
            Exit.BackColor = Color.FromName("RoyalBlue");
            topPanel.BackColor = Color.FromName("RoyalBlue");
        }

        private void AboutUs_Click(object sender, EventArgs e)
        {
            AboutUs about = new AboutUs();
            sPlayer.Play();
            secPanel.Controls.Add(about);
            about.BringToFront();
            about.Size = this.Size;
            Headline.Text = "ABOUT US";
            Headline.BackColor = Color.FromName("RoyalBlue");
            Minimize.BackColor = Color.FromName("RoyalBlue");
            Exit.BackColor = Color.FromName("RoyalBlue");
            topPanel.BackColor = Color.FromName("RoyalBlue");
        }
    }
}
