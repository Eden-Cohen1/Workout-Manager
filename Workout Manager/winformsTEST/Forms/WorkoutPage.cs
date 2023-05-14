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
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace winformsTEST
{
    public partial class WorkoutPage : UserControl
    {
        public static WorkoutPage instance;
        public static Workout currWorkout;
        public static Exercise currExercise;
        public WorkoutPage()
        {
            InitializeComponent();
            instance = this;
        }
        private void deleteBTN_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in ExerciseList.Items)
            {
                if (item.Selected == true)
                {
                    foreach (Exercise ex in currWorkout._ExerciseList)
                    {
                        if (ex._name == item.SubItems[0].Text)
                        {
                            currWorkout._ExerciseList.Remove(ex);
                            ExerciseList.Items.Remove(item);
                            break;
                        }
                    }

                }
            }
        }

        private void editBTN_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in ExerciseList.Items)
            {
                if (item.Selected == true)
                {
                    foreach (Exercise ex in currWorkout._ExerciseList)
                    {
                        if (ex._name == item.SubItems[0].Text)
                        {
                            EditEx edit_window = new EditEx();
                            if (ex.type == 1)
                            {
                                edit_window.restTextBox.Enabled = false;
                                edit_window.distanceTextBox.Enabled = false;
                                edit_window.PaceTextBox.Enabled = false;
                                edit_window.intenseDropDown.Enabled = false;

                                edit_window.nameTextBox.Text = item.SubItems[0].Text;
                                edit_window.muscleTextBox.Text = item.SubItems[1].Text;
                                edit_window.setsTextBox.Text = item.SubItems[2].Text;
                                edit_window.repTextBox.Text = item.SubItems[3].Text;
                                edit_window.weightTextBox.Text = item.SubItems[4].Text;
                                edit_window.restTextBox.Text = item.SubItems[5].Text.Split(' ')[0];


                            }
                            else if (ex.type == 2)
                            {
                                edit_window.repTextBox.Enabled = false;
                                edit_window.weightTextBox.Enabled = false;
                                edit_window.distanceTextBox.Enabled = false;
                                edit_window.PaceTextBox.Enabled = false;

                                edit_window.nameTextBox.Text = item.SubItems[0].Text;
                                edit_window.muscleTextBox.Text = item.SubItems[1].Text;
                                edit_window.setsTextBox.Text = item.SubItems[2].Text;
                                edit_window.restTextBox.Text = item.SubItems[5].Text.Split(' ')[0];
                            }
                            else
                            {
                                edit_window.repTextBox.Enabled = false;
                                edit_window.setsTextBox.Enabled = false;
                                edit_window.weightTextBox.Enabled = false;
                                edit_window.intenseDropDown.Enabled = false;

                                edit_window.nameTextBox.Text = item.SubItems[0].Text;
                                edit_window.muscleTextBox.Text = item.SubItems[1].Text;
                                edit_window.PaceTextBox.Text = item.SubItems[7].Text;
                                edit_window.distanceTextBox.Text = item.SubItems[6].Text.Split(' ')[0];
                                edit_window.restTextBox.Text = item.SubItems[7].Text.Split(' ')[0];
                            }
                            currExercise =ex;
                            item.Remove();
                            edit_window.ShowDialog();

                        }
                    }
                }
            }
        }

        private void Add_Ex_Click(object sender, EventArgs e)
        {
            AddEx screen = new AddEx();
            MainForm.instance.secPanel.Controls.Add(screen);
            screen.BringToFront();
            screen.Dock = DockStyle.Fill;
            AddEx.newEx = true;

        }
    }
}
