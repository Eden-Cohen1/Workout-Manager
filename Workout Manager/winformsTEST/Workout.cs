using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EXERCISE;

namespace winformsTEST
{
    [Serializable]
    public class Workout // types: 1 for Strenght, 2 for Stamina;
    {
        public int type { get; set; }
        public string _workoutName { get; set; }
        public string _Description { get; set; }
        public string _Duration { get; set; }
        public List<Exercise> _ExerciseList { get; set; }


        public Workout()
        {
            _workoutName = "No Name";
            _Description = "No Description.";
            _Duration = "No Duration";
        }
        public Workout(string name, string description, string duration)
        {
            this._ExerciseList = new List<Exercise>();
            this._workoutName = name;
            this._Description = description;
            this._Duration = duration;
        }

    }
    [Serializable]
    public class StrenghtWorkout: Workout
    {
        int _totalNumOfSets { get; set; }
        int _totalKilosLifted { get; set; }
        string TrainingArea { get; set; }

        public StrenghtWorkout()
        {
            type = 1;
            _totalKilosLifted = 0;
            _totalNumOfSets = 0;
            TrainingArea = "Home";
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
            TrainingArea = "Home";
        }

    }
    [Serializable]
    public class CardioWorkout : Workout
    {
        public double _totalCalories { get; set; }

        public CardioWorkout()
        {
            type = 2;
            _totalCalories = calculateCalories();
        }
        public CardioWorkout(string name, string description, string duration)
        {
            this._ExerciseList = new List<Exercise>();
            this._workoutName = name;
            this._Description = description;
            this._Duration = duration;
            type = 2;
            _totalCalories = calculateCalories();
        }
        public double calculateCalories()
        {
            double result = 0.0; int i;
            for (i = 0; i < _ExerciseList.Count; i++)
            {
                result += _ExerciseList[i].CalcCalories();
            }
            return result;
        }

    }
/*
    public class HIIT: CardioWorkout
    {
        int _intervalCount { get; set; }
        int _intervalDur { get; set; }
        int _restTime { get; set; }

        public override double calculateCalories()
        {
            double result =0.0; int i;
            for(i = 0; i < _ExerciseList.Count; i++)
            {
               result +=  _ExerciseList[i].CalcCalories();
            }
            return result;
        }
    }
    public class Endurance: CardioWorkout
    {
        double _distance { get; set; }
        double _avragePace { get; set; }

        

        public override double calculateCalories()
        {
            double result = 0.0; int i;
            for (i = 0; i < _ExerciseList.Count; i++)
            {
                result += _ExerciseList[i].CalcCalories();
            }
            return result;
        }
    }*/
}
