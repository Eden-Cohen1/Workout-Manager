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

namespace winformsTEST
{
/*    public static List<Workout>
*/
    public partial class Form1 : Form
    {
        public static Form1 instance;
        public static myWorkouts screen;
        public Form1()
        {
            InitializeComponent();
            /*            this.WindowState = FormWindowState.Normal;
                        this.Size = new Size(1150, 800);*/
            screen = new myWorkouts();
            this.WindowState = FormWindowState.Maximized;
            secPanel.AutoSize = true;
            instance = this;
        }
        public Form1(string name)
        {
            InitializeComponent();
        }

        private void newWorkout_Click(object sender, EventArgs e)
        {
            AddWorkout screen = new AddWorkout();
            secPanel.Controls.Add(screen);
            screen.BringToFront();
            screen.Size = this.Size;

        }

        private void Home_Click(object sender, EventArgs e)
        {
            secPanel.Controls.Clear();
            secPanel.BackColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
/*            myWorkouts screen = new myWorkouts();
*/            secPanel.Controls.Add(screen);
            screen.BringToFront();
            screen.Size = this.Size;
            foreach (Workout workout in AddWorkout.workout_list)
            {
                string type;
                if(workout.type == 1)
                {
                    type = "Strenght Workout";
                }
                else if(workout.type == 2)
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
                string[] listnames = { name, duration, type, description };
                var listviewitem = new ListViewItem(listnames);
                myWorkouts.instance.myWorkoutsList.Items.Add(listviewitem);
            }
        }
    }
}
