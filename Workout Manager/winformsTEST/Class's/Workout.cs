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

        public Image logo { get; set; }
        public List<Exercise> _ExerciseList { get; set; }


        public Workout(){}
        public void CalcTotalCalories()
        {
            _totalCalories = 0;
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

        public StrenghtWorkout()
        {
            type = 1;
            logo = Properties.Resources.Strenght;
        }
        public StrenghtWorkout(string name, string description, string duration)
        {
            this._ExerciseList = new List<Exercise>();
            this._workoutName = name;
            this._Description = description;
            this._Duration = duration;
            this.type = 1;
            this.logo = Properties.Resources.Strenght;

        }

    }
    [Serializable]
    public class CardioWorkout : Workout
    {
        public CardioWorkout()
        {
            this.type = 2;
            this.logo = Properties.Resources.Endurance;

        }
        public CardioWorkout(string name, string description, string duration)
        {
            this._ExerciseList = new List<Exercise>();
            this._workoutName = name;
            this._Description = description;
            this._Duration = duration;
            this.logo = Properties.Resources.Endurance;
            this.type = 2;
        }

    }
}
