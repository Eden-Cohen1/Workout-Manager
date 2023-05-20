using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EXERCISE;
using System.Drawing;


namespace winformsTEST
{
    [Serializable]
    public class Workout // types: 1 for Strenght, 2 for Stamina;
    {
        public int type { get; set; }
        public string _workoutName { get; set; }
        public string _Description { get; set; }
        public string _Duration { get; set; }
        public int _totalCalories { get; set; }

        public Image logo;
        public List<Exercise> _ExerciseList { get; set; }


        public Workout()
        {
            _workoutName = "No Name";
            _Description = "No Description.";
            _Duration = "No Duration";
            _totalCalories = 0;
        }
        public Workout(string name, string description, string duration)
        {
            this._ExerciseList = new List<Exercise>();
            this._workoutName = name;
            this._Description = description;
            this._Duration = duration;
            this._totalCalories = 0;

        }

        public void CalcTotalCalories()
        {
            if (_ExerciseList.Count == 0)
            {
                return;
            }

            foreach(Exercise ex in _ExerciseList)
            {
                _totalCalories += ex._calBurned;
            }
        }

    }
    [Serializable]
    public class StrenghtWorkout: Workout
    {
        int _totalNumOfSets { get; set; }
        int _totalKilosLifted { get; set; }

        public StrenghtWorkout()
        {
            type = 1;
            _totalKilosLifted = 0;
            _totalNumOfSets = 0;
            logo = Image.FromFile(@"Strenght.png");
        }
        public StrenghtWorkout(string name, string description, string duration)
        {
            this._ExerciseList = new List<Exercise>();
            this._workoutName = name;
            this._Description = description;
            this._Duration = duration;
            type = 1;
            _totalKilosLifted = 0;
            _totalNumOfSets = 0;
            logo = Image.FromFile(@"Strenght.png");

        }

    }
    [Serializable]
    public class CardioWorkout : Workout
    {
        public CardioWorkout()
        {
            type = 2;
            logo = Image.FromFile(@"Endurance.png");

        }
        public CardioWorkout(string name, string description, string duration)
        {
            this._ExerciseList = new List<Exercise>();
            this._workoutName = name;
            this._Description = description;
            this._Duration = duration;
            logo = Image.FromFile(@"Endurance.png");
            type = 2;
        }

    }
}
