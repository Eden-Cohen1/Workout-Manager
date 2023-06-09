﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;//!!!!!!
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace winformsTEST
{
    public partial class AddWorkout : UserControl
    {
        public static List<Workout> workout_list = new List<Workout>(); // main list for storing all the workouts, reading and writing data.

        int workout_flag = 0; 
        // important! workout is created as soon as we add an exercise, so it should create a workout 
        // only with the first exercise add, the workout flag indicates 1 for a workout object already created.

        private bool isCollapsed; //for the dropdown menu
        public static AddWorkout instance;
        public AddWorkout()
        {

            workout_flag = 0;
            InitializeComponent();
            instance = this;

        }
        private void Add_workout_Click(object sender, EventArgs e)
        {
            Mainform.sPlayer.Play();
            workoutAdded.Enabled = true;
            workoutAdded.Visible = true;
            workout_flag = 0;
            foreach (Control control in this.Controls)
            {
                if(control is TextBox)
                {
                    control.Text = "" ;
                }
            }
            string type;
            Workout last_workout = workout_list.ElementAt(workout_list.Count - 1);
            if (last_workout.type == 1)
            {
                type = "Strenght Workout";
            }
            else if (last_workout.type == 2)
            {
                type = "Cardio Workout";

            }
            else
            {
                type = "NO TYPE";
            }
            last_workout.CalcTotalCalories();
            string name = last_workout._workoutName;
            string description = last_workout._Description;
            string duration = last_workout._Duration;
            string calories = last_workout._totalCalories.ToString();
            string[] listnames = { name, duration + " minutes", type, description, calories };
            var listviewitem = new ListViewItem(listnames);
            myWorkouts.instance.myWorkoutsList.Items.Add(listviewitem);
            ExList.Items.Clear();
            muscleList.Items.Clear();
            Mainform.instance.countLabel.Text = workout_list.Count().ToString();
        }

        private void Add_New_Ex_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameTextBox.Text) || string.IsNullOrEmpty(DurationTextBox.Text)
                || string.IsNullOrEmpty(DescriptionTextBox.Text) || dropDown.Text == "CHOOSE A TYPE")
            {
                DialogResult error = MessageBox.Show("Fill all text boxes", "Error!", MessageBoxButtons.OK);
                return;
            }
            Mainform.sPlayer.Play();
            AddEx screen = new AddEx();
            Mainform.instance.secPanel.Controls.Add(screen);
            screen.BringToFront();
            AddEx.newEx = false;

            if(dropDown.Text == "STRENGHT WORKOUT" && workout_flag == 0)
            {
                StrenghtWorkout workout = new StrenghtWorkout(nameTextBox.Text, DescriptionTextBox.Text, DurationTextBox.Text);
                workout_list.Add(workout); // creating a new workout as the exercise button is clicked, and adding it to the workout list
                workout_flag = 1;
            }
            else if(workout_flag == 0)
            {
                CardioWorkout workout = new CardioWorkout(nameTextBox.Text, DescriptionTextBox.Text, DurationTextBox.Text);
                workout_list.Add(workout); // creating a new workout as the exercise button is clicked, and adding it to the workout list
                workout_flag = 1;

            }
            Mainform.instance.Headline.Text = "ADDING A NEW EXERCISE";
            Mainform.instance.Headline.BackColor = Color.FromName("RoyalBlue");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                /*                dropDown.Image = Image.FromFile(@"C: \Users\eden7\OneDrive\Desktop\Assets\Up_Arrow.png");
                */
                typeDropDown.Height += 10;
                if (typeDropDown.Size == typeDropDown.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                typeDropDown.Height -= 10;
                if (typeDropDown.Size == typeDropDown.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void dropDown_Click(object sender, EventArgs e)
        {
            Mainform.sPlayer.Play();
            timer1.Start();
        }

        private void StrenghtW_Click(object sender, EventArgs e)
        {
            Mainform.sPlayer.Play();
            timer1.Start();
            dropDown.Text = StrenghtW.Text;
        }

        private void CardioW_Click(object sender, EventArgs e)
        {
            Mainform.sPlayer.Play();
            timer1.Start();
            dropDown.Text = CardioW.Text;
        }

        private void DurationTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
