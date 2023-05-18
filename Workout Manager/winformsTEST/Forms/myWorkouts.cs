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
    public partial class myWorkouts : UserControl
    {
        public static string rest = "1:30 minutes";
        public static string none = "-------";
        public static myWorkouts instance;

        public myWorkouts()
        {
            InitializeComponent();
            instance = this;
        }

        private void ViewWorkout_Click(object sender, EventArgs e) //open view workout page and fill out the workout exercises.
        {
            Mainform.sPlayer.Play();
            foreach (ListViewItem item in myWorkoutsList.Items)
            {
                if (item.Selected == true)
                {
                    WorkoutPage screen = new WorkoutPage();
                    Mainform.instance.secPanel.Controls.Add(screen);
                    screen.BringToFront();
                    foreach (Workout workout in AddWorkout.workout_list) {
                        if(workout._workoutName == item.SubItems[0].Text) // searches for the correct workout
                        {
                            Mainform.instance.Headline.Text = workout._workoutName;
                            WorkoutPage.currWorkout = workout;
                            foreach (StrenghtExercise ex in workout._ExerciseList.OfType<StrenghtExercise>()) // for the strenght workouts
                            {
                                string name = ex._name;
                                string muscle = ex._muscle.getName();
                                string sets = ex._sets.ToString();
                                string reps = ex._reps.ToString();
                                string weight = ex._weight.ToString();
                                string[] listnames = { name, muscle, sets, reps, weight, rest,none, none,none, };
                                var listviewitem = new ListViewItem(listnames);
                                screen.ExerciseList.Items.Add(listviewitem);
                                
                            }
                            foreach (EnduranceExercise ex in workout._ExerciseList.OfType<EnduranceExercise>()) // for the endurance workouts
                             {
                                string name = ex._name;
                                string muscle = ex._muscle.getName();
                                string distance = ex._distance.ToString() + " km";
                                string pase = ex._avragePace.ToString();
                                string[] listnames = { name, muscle, none, none, none, none,distance, pase, none };
                                var listviewitem = new ListViewItem(listnames);
                                screen.ExerciseList.Items.Add(listviewitem);

                            }
                            foreach (HIITExercise ex in workout._ExerciseList.OfType<HIITExercise>()) // for the HIIT workouts
                            {
                                string intensity;
                                switch (ex._intensity)
                                {
                                    case 1:
                                        intensity = "Easy";
                                            break;
                                    case 2:
                                        intensity = "Mediom";
                                        break;
                                    default:
                                        intensity = "Hard";
                                        break;
                                }
                                string name = ex._name;
                                string muscle = ex._muscle.getName();
                                string restTime = ex._restTime.ToString() + " minutes";
                                string intervalCount = ex._intervalCount.ToString();
                                string[] listnames = { name, muscle, intervalCount, none,none,restTime,none,none,intensity };
                                var listviewitem = new ListViewItem(listnames);
                                screen.ExerciseList.Items.Add(listviewitem);
                                
                            }
                            break;

                        }
                    }

                }
            }
        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            Mainform.sPlayer.Play();
            foreach (ListViewItem item in myWorkoutsList.Items)
            {
                if (item.Selected == true)
                {
                    foreach (Workout workout in AddWorkout.workout_list)
                    {
                        if (workout._workoutName == item.SubItems[0].Text)
                        {
                            AddWorkout.workout_list.Remove(workout);
                            myWorkoutsList.Items.Remove(item);
                            break;
                        }
                    }

                }
            }

        }


    }
}
