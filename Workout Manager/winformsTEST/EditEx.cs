using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EXERCISE;
using System.Runtime.Serialization;//!!!!!!
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace winformsTEST
{
    public partial class EditEx : Form
    {
        private int intansityFlag;
        private bool isCollapsed; //for the dropdown menu

        public EditEx()
        {
            InitializeComponent();
        }

        private void intensityDropDown_Click(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                intenseDropDown.Height += 10;
                if (intenseDropDown.Size == intenseDropDown.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                intenseDropDown.Height -= 10;
                if (intenseDropDown.Size == intenseDropDown.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void Easy_Click(object sender, EventArgs e)
        {
            timer1.Start();
            intensityDropDown.Text = Easy.Text;
            intansityFlag = 1; // setting intensity level for adding the exercise
        }

        private void Medium_Click(object sender, EventArgs e)
        {
            timer1.Start();
            intensityDropDown.Text = Medium.Text;
            intansityFlag = 2;
        }

        private void Hard_Click(object sender, EventArgs e)
        {
            timer1.Start();
            intensityDropDown.Text = Hard.Text;
            intansityFlag = 3;
        }

        private void SaveChanges_Click(object sender, EventArgs e)
        {
            WorkoutPage.currExercise._name = nameTextBox.Text;
            WorkoutPage.currExercise._muscle._name = muscleTextBox.Text;

            if (WorkoutPage.currExercise is StrenghtExercise)
            {
                ((StrenghtExercise)WorkoutPage.currExercise)._reps = int.Parse(repTextBox.Text);
                ((StrenghtExercise)WorkoutPage.currExercise)._sets = int.Parse(setsTextBox.Text);
                ((StrenghtExercise)WorkoutPage.currExercise)._weight = double.Parse(weightTextBox.Text);

            }
            else if(WorkoutPage.currExercise is EnduranceExercise)
            {
                ((EnduranceExercise)WorkoutPage.currExercise)._distance = double.Parse(distanceTextBox.Text);
                ((EnduranceExercise)WorkoutPage.currExercise)._avragePace = double.Parse(PaceTextBox.Text);
            }
            else
            {
                ((HIITExercise)WorkoutPage.currExercise)._restTime = double.Parse(restTextBox.Text);
                ((HIITExercise)WorkoutPage.currExercise)._intervalCount = int.Parse(setsTextBox.Text);
                ((HIITExercise)WorkoutPage.currExercise)._intensity = intansityFlag;
            }
            WorkoutPage.instance.Refresh();
            this.Close();

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
