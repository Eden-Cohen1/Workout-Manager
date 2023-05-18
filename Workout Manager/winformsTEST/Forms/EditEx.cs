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
            Mainform.sPlayer.Play();
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e) // dropdown manu for intensity
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
            Mainform.sPlayer.Play();
            timer1.Start();
            intensityDropDown.Text = Easy.Text;
            intansityFlag = 1; // setting intensity level for adding the exercise
        }

        private void Medium_Click(object sender, EventArgs e)
        {
            Mainform.sPlayer.Play();
            timer1.Start();
            intensityDropDown.Text = Medium.Text;
            intansityFlag = 2;
        }

        private void Hard_Click(object sender, EventArgs e)
        {
            Mainform.sPlayer.Play();
            timer1.Start();
            intensityDropDown.Text = Hard.Text;
            intansityFlag = 3;
        }

        private void SaveChanges_Click(object sender, EventArgs e)
        {
            Mainform.sPlayer.Play();
            WorkoutPage.currExercise._name = nameTextBox.Text;
            WorkoutPage.currExercise._muscle._name = muscleTextBox.Text;
            
            if (WorkoutPage.currExercise is StrenghtExercise)
            {
                ((StrenghtExercise)WorkoutPage.currExercise)._reps = int.Parse(repTextBox.Text);
                ((StrenghtExercise)WorkoutPage.currExercise)._sets = int.Parse(setsTextBox.Text);
                ((StrenghtExercise)WorkoutPage.currExercise)._weight = double.Parse(weightTextBox.Text);
                AddEx.update_list_Strenght((StrenghtExercise)WorkoutPage.currExercise);


            }
            else if(WorkoutPage.currExercise is EnduranceExercise)
            {
                ((EnduranceExercise)WorkoutPage.currExercise)._distance = double.Parse(distanceTextBox.Text);
                ((EnduranceExercise)WorkoutPage.currExercise)._avragePace = double.Parse(PaceTextBox.Text);
                AddEx.update_list_Endurance((EnduranceExercise)WorkoutPage.currExercise);

            }
            else
            {
                ((HIITExercise)WorkoutPage.currExercise)._restTime = double.Parse(restTextBox.Text);
                ((HIITExercise)WorkoutPage.currExercise)._intervalCount = int.Parse(setsTextBox.Text);
                ((HIITExercise)WorkoutPage.currExercise)._intensity = intansityFlag;
                AddEx.update_list_HIIT((HIITExercise)WorkoutPage.currExercise);

            }
            this.Close();

        }

       
        private void Exit_Click(object sender, EventArgs e)
        {
            Mainform.sPlayer.Play();
            this.Close();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            Mainform.sPlayer.Play();
            this.WindowState = FormWindowState.Minimized;
        }

        private void repTextBox_KeyPress(object sender, KeyPressEventArgs e) // disable unnecessary text boxes.
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void setsTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void weightTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void restTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void distanceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void PaceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
