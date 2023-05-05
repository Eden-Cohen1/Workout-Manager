using System;
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
        public static List<Workout> workout_list = new List<Workout>();

        private bool isCollapsed; //for the dropdown menu
        public static AddWorkout instance;
        public AddWorkout()
        {
            InitializeComponent();
            instance = this;
            

        }
        private void button1_Click(object sender, EventArgs e)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("main_file", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, workout_list);
            workoutAdded.Enabled = true;
            workoutAdded.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            AddEx screen = new AddEx();
            Form1.instance.secPanel.Controls.Add(screen);
            screen.BringToFront();

            if(dropDown.Text == "STRENGHT WORKOUT")
            {
                StrenghtWorkout workout = new StrenghtWorkout(nameTextBox.Text, DescriptionTextBox.Text, DurationTextBox.Text);
                workout_list.Add(workout); // creating a new workout as the exercise button is clicked, and adding it to the workout list
            }
            else
            {
                CardioWorkout workout = new CardioWorkout(nameTextBox.Text, DescriptionTextBox.Text, DurationTextBox.Text);
                workout_list.Add(workout); // creating a new workout as the exercise button is clicked, and adding it to the workout list
            }
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
            timer1.Start();
        }

        private void StrenghtW_Click(object sender, EventArgs e)
        {
            timer1.Start();
            dropDown.Text = StrenghtW.Text;
        }

        private void CardioW_Click(object sender, EventArgs e)
        {
            timer1.Start();
            dropDown.Text = CardioW.Text;
        }

        private void AddWorkout_Load(object sender, EventArgs e)
        {

        }
    }
}
