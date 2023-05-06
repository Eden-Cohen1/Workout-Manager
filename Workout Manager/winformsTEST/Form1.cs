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
using System.Runtime.Serialization;//!!!!!!
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace winformsTEST
{

    public partial class MainForm : Form
    {
        public static MainForm instance;
        public static myWorkouts screen;
        public static AddWorkout screen2;

        public MainForm()
        {
            InitializeComponent();
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
                string[] listnames = { name, duration + " minutes", type, description };
                var listviewitem = new ListViewItem(listnames);
                myWorkouts.instance.myWorkoutsList.Items.Add(listviewitem);
            }
        }
        public MainForm(string name)
        {
            InitializeComponent();
        }

        private void newWorkout_Click(object sender, EventArgs e)
        {
            secPanel.Controls.Add(screen2);
            screen2.BringToFront();
            screen2.Size = secPanel.Size;
            AddWorkout.instance.workoutAdded.Visible = false;
            Headline.Text = "ADDING A NEW WORKOUT ";
            Headline.BackColor = Color.FromName("RoyalBlue");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            secPanel.Controls.Add(screen);
            screen.BringToFront();
            screen.Size = this.Size;
            Headline.Text = "MY WORKOUTS";
            Headline.BackColor = Color.FromName("RoyalBlue");
        }


        private void button5_Click(object sender, EventArgs e)
        {
            secPanel.Controls.Add(background);
            background.BringToFront();
            Headline.Text = "HOME";
            Headline.BackColor = Color.FromArgb(28, 26, 33);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
