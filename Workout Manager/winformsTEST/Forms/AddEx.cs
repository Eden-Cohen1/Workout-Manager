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

namespace winformsTEST
{
    public partial class AddEx : UserControl
    {
        public static AddEx instance;
        public int ExType; // flag for exercise type the was chosen
        public int Intensity; // flag for intesity level of hiit exercise
        private bool isCollapsed; //for the dropdown menu
        public static bool newEx; // existing or new workout

        public AddEx()
        {
            InitializeComponent();
            instance = this;
        }


        private void dropDown_Click(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
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

        private void Stamina_Click(object sender, EventArgs e)
        {
            EnduranceEx ex = new EnduranceEx();
            this.Controls.Add(ex);
            ex.Location = changeByType.Location;
            ex.BringToFront();
            ex.Size = changeByType.Size;
            timer1.Start();
            dropDown.Text = Stamina.Text;
            ExType = 1;
        }

        private void Strenght_Click(object sender, EventArgs e)
        {
            StrenghtEx ex = new StrenghtEx();
            this.Controls.Add(ex);
            ex.Location = changeByType.Location;
            ex.BringToFront();
            ex.Size = changeByType.Size;

            timer1.Start();
            dropDown.Text = Strenght.Text;
            ExType = 2;


        }

        private void HIIT_Click(object sender, EventArgs e)
        {
            HIITEx ex = new HIITEx();
            this.Controls.Add(ex);
            ex.Location = changeByType.Location;
            ex.BringToFront();
            ex.Size = changeByType.Size;
            timer1.Start();
            dropDown.Text = HIIT.Text;
            ExType = 3;

        }

        private void doneAddingEx_Click(object sender, EventArgs e)
        {
            // getting all of the data from the needed forms, converting it to
            // the correct data type and sending to the right constructor, then
            // adding the new exercise that was created to the exercise list of the last workout...
            if (newEx == false) // adding an exercise to a new workout.
            {
                if (ExType == 1)
                {
                    //add "if text is string... (empty input throws exeption)
                    double distance, pace;
                    distance = double.Parse(EnduranceEx.instance.distanceTextBox.Text); // from string to double
                    pace = double.Parse(EnduranceEx.instance.PaceTextBox.Text); // from string to double
                    EnduranceExercise Exer = new EnduranceExercise(distance, pace, nameTextBox.Text, muscleTextBox.Text);
                    AddWorkout.workout_list.ElementAt(AddWorkout.workout_list.Count - 1)._ExerciseList.Add(Exer);
                    AddWorkout.instance.ExList.Items.Add(Exer._name.ToUpper());
                    AddWorkout.instance.muscleList.Items.Add(Exer._muscle.getName().ToUpper());

                }
                else if (ExType == 2)
                {
                    double weight;
                    int sets, reps;
                    weight = double.Parse(StrenghtEx.instance.weightTextBox.Text);
                    sets = int.Parse(StrenghtEx.instance.setsTextBox.Text);
                    reps = int.Parse(StrenghtEx.instance.repTextBox.Text);

                    StrenghtExercise Exer = new StrenghtExercise(weight, reps, sets, nameTextBox.Text, muscleTextBox.Text); // dupp forr all options
                    AddWorkout.workout_list.ElementAt(AddWorkout.workout_list.Count - 1)._ExerciseList.Add(Exer);
                    AddWorkout.instance.ExList.Items.Add(Exer._name.ToUpper());
                    AddWorkout.instance.muscleList.Items.Add(Exer._muscle.getName().ToUpper());


                }
                else if (ExType == 3)
                {
                    int intr;
                    double rest;
                    rest = double.Parse(HIITEx.instance.restTextBox.Text);
                    intr = int.Parse(HIITEx.instance.intrcountTextBox.Text);
                    HIITExercise Exer = new HIITExercise(intr, rest, Intensity, nameTextBox.Text, muscleTextBox.Text);
                    AddWorkout.workout_list.ElementAt(AddWorkout.workout_list.Count - 1)._ExerciseList.Add(Exer);
                    AddWorkout.instance.ExList.Items.Add(Exer._name.ToUpper());
                    AddWorkout.instance.muscleList.Items.Add(Exer._muscle.getName().ToUpper());


                }
            }

            else // adding an exercise to an existing workout.
            {

                if (ExType == 1)
                {
                    //add "if text is string... (empty input throws exeption)
                    double distance, pace;
                    distance = double.Parse(EnduranceEx.instance.distanceTextBox.Text); // from string to double
                    pace = double.Parse(EnduranceEx.instance.PaceTextBox.Text); // from string to double
                    EnduranceExercise Exer = new EnduranceExercise(distance, pace, nameTextBox.Text, muscleTextBox.Text);
                    WorkoutPage.currWorkout._ExerciseList.Add(Exer);
                    update_list_Endurance(Exer);

                }
                else if (ExType == 2)
                {
                    double weight;
                    int sets, reps;
                    weight = double.Parse(StrenghtEx.instance.weightTextBox.Text);
                    sets = int.Parse(StrenghtEx.instance.setsTextBox.Text);
                    reps = int.Parse(StrenghtEx.instance.repTextBox.Text);

                    StrenghtExercise Exer = new StrenghtExercise(weight, reps, sets, nameTextBox.Text, muscleTextBox.Text); // dupp forr all options
                    WorkoutPage.currWorkout._ExerciseList.Add(Exer);
                    update_list_Strenght(Exer);

                }
                else if (ExType == 3)
                {
                    int intr;
                    double rest;
                    rest = double.Parse(HIITEx.instance.restTextBox.Text);
                    intr = int.Parse(HIITEx.instance.intrcountTextBox.Text);
                    HIITExercise Exer = new HIITExercise(intr, rest, Intensity, nameTextBox.Text, muscleTextBox.Text);
                    WorkoutPage.currWorkout._ExerciseList.Add(Exer);
                    update_list_HIIT(Exer);
                }
            }
            Mainform.instance.secPanel.Controls.Remove(this);
        }

        public static void update_list_Strenght(StrenghtExercise Exer)
        {
            string name = Exer._name;
            string muscle = Exer._muscle.getName();
            string sets = Exer._sets.ToString();
            string reps = Exer._reps.ToString();
            string weight = Exer._weight.ToString();
            string[] listnames = { name, muscle, sets, reps, weight, myWorkouts.rest, myWorkouts.none, myWorkouts.none, myWorkouts.none, };
            var listviewitem = new ListViewItem(listnames);
            WorkoutPage.instance.ExerciseList.Items.Add(listviewitem);

        }
        public static void update_list_Endurance(EnduranceExercise Exer)
        {
            string name = Exer._name;
            string muscle = Exer._muscle.getName();
            string distance = Exer._distance.ToString() + " km";
            string pase = Exer._avragePace.ToString();
            string[] listnames = { name, muscle, myWorkouts.none, myWorkouts.none, myWorkouts.none, myWorkouts.none, distance, pase, myWorkouts.none };
            var listviewitem = new ListViewItem(listnames);
            WorkoutPage.instance.ExerciseList.Items.Add(listviewitem);

        }

        public static void update_list_HIIT(HIITExercise Exer)
        {
            string intensity;
            switch (Exer._intensity)
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
            string name = Exer._name;
            string muscle = Exer._muscle.getName();
            string restTime = Exer._restTime.ToString() + " minutes";
            string intervalCount = Exer._intervalCount.ToString();
            string[] listnames = { name, muscle, intervalCount, myWorkouts.none, myWorkouts.none, restTime, myWorkouts.none, myWorkouts.none, intensity };
            var listviewitem = new ListViewItem(listnames);
            WorkoutPage.instance.ExerciseList.Items.Add(listviewitem);

        }
    }
}

