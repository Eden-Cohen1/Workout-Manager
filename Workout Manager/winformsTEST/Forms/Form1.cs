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
        public static myWorkouts workoutScreen;
        public static AddWorkout addWorkoutScreen;
        public static Videos videoScreen;
        public static AboutUs aboutScreen;
        public static SoundPlayer sPlayer = new SoundPlayer(@"button2.wav");
        public int soundOnFlag = 1; // to check if background music is on or off;
        public Mainform()
        {
            InitializeComponent();
            backMusic();
            instance = this;
            //initilizing all of the screens
            workoutScreen = new myWorkouts();
            addWorkoutScreen = new AddWorkout();
            videoScreen = new Videos();
            aboutScreen = new AboutUs();
            secPanel.AutoSize = true;

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
        private void backMusic() // setting background music
        {
            backgroundMusic.URL = @"background-music.wav";
            backgroundMusic.settings.playCount = 9999;
            backgroundMusic.Visible = false;
            backgroundMusic.settings.volume = 20;
        }
        private void Home_Click(object sender, EventArgs e) // hoem page
        {
            Menue_click(null, Color.FromArgb(28, 26, 33), "HOME");
            secPanel.Controls.Add(background);
            background.BringToFront();
        }
        private void newWorkout_Click(object sender, EventArgs e) // new workout page
        {
            Menue_click(addWorkoutScreen, Color.FromName("RoyalBlue"), "ADDING A NEW WORKOUT");
            AddWorkout.instance.workoutAdded.Visible = false;
        }

        private void myWorkouts_Click(object sender, EventArgs e) // my workouts page
        {
            Menue_click(workoutScreen, Color.FromName("RoyalBlue"), "MY WORKOUTS");
        }

        private void Videos_Click(object sender, EventArgs e) // videos page
        {
            Menue_click(videoScreen, Color.FromName("RoyalBlue"), "VIDEO TUTURIALS");
        }

        private void AboutUs_Click(object sender, EventArgs e) // about us page
        {
            Menue_click(aboutScreen, Color.FromName("RoyalBlue"), "ABOUT US");

        }


        private void Menue_click(UserControl screen, Color backColor, string text) // opens a program screen and setting it up.
        {
            if (screen != null)
            {
                secPanel.Controls.Add(screen);
                screen.BringToFront();
                screen.Size = this.Size;
            }
            sPlayer.Play();
            Headline.Text = text;
            Headline.BackColor = backColor;
            Minimize.BackColor = backColor;
            Exit.BackColor = backColor;
            topPanel.BackColor = backColor;
            workout_logo.Visible = false;
            videoScreen.VideoPlayer.Ctlcontrols.pause(); // stops the video when switching to another screen.
        }


        private void Exit_Click(object sender, EventArgs e) // closing form and serelizing data
        {
            sPlayer.Play();
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("main_file", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, AddWorkout.workout_list);
            stream.Close();
            this.Close();
        }

        private void Minimize_Click(object sender, EventArgs e) // minimize
        {
            sPlayer.Play();
            this.WindowState = FormWindowState.Minimized;
        }

        private void Sound_Click(object sender, EventArgs e) // muting and playing background music
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

    }
}
