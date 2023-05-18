using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using MUSCLE;
using winformsTEST;
namespace EXERCISE
{
    [Serializable]
    public abstract class Exercise // types: 1 for strenght, 2 for hitt, 3 for endurance
    {
        public int type;
        public string _name { get; set; }
        public Muscle _muscle { get; set; }
        
        public int _calories;

        public int _calBurned;
        public  Exercise()
        {
            this._name = "No Name";
            this._muscle = new Muscle();
        }

        public virtual int CalcCalories()
        {
            return 0;
        }

    }
    [Serializable]
    public class StrenghtExercise : Exercise
    {
        public double _weight { get; set; }
        public int _reps { get; set; }
        public int _sets { get; set; }

        public StrenghtExercise()
        {
             type = 1;
            _weight = 0;
            _reps = 0;
            _sets = 0;
            _calories = 20;
        }
        public StrenghtExercise(double weight, int reps, int sets, string name,string muscle)
        {
            type = 1;
            _weight = weight;
            _reps = reps;
            _sets = sets;
            _name = name;
            _muscle = new Muscle(muscle);
            _calories = 5;
            _calBurned = CalcCalories();


        }
        public override int CalcCalories()
        {
            return _reps * _sets * _calories;
        }
    }
    [Serializable]
    public class StaminaExercise : Exercise
    {
        protected int _duration { get; set; }
        protected double _caloriesPerMin { get; set; }

        public StaminaExercise()
        {
            _duration = 0;
            _calories = 10;
        }

        public override int CalcCalories()
        {
            return  _duration * _calories;
        }
    }
    [Serializable]
    public class HIITExercise : StaminaExercise
    {
        public int _intervalCount { get; set; }
        public double _restTime { get; set; }
        public int _intensity { get; set; }

        public HIITExercise()
        {
            type = 2;
            _intervalCount = 0;
            _restTime = 0;
            _calories = 10;
            
        }
        public HIITExercise(int numOfIntervals, double rest, int intensity,string name, string muscle)
        {
            type = 2;
            _intervalCount = numOfIntervals;
            _restTime = rest;
            _intensity = intensity;
            _name = name;
            _muscle = new Muscle(muscle);
            _calBurned = CalcCalories();

        }
        public override int CalcCalories()
        {
            return _intervalCount * _intensity * _calories;
        }
    }
    [Serializable]
    public class EnduranceExercise : StaminaExercise
    {
        public double _distance { get; set; }
        public double _avragePace { get; set; }

        public EnduranceExercise()
        {
            type = 3;
            _distance = 0;
            _avragePace = 0;
            _calories = 5;
        }
        public EnduranceExercise(double distance, double pace, string name, string muscle)
        {
            type = 3;
            _distance = distance;
            _avragePace = pace;
            _name = name;
            _muscle = new Muscle(muscle);
            _calories = 5;
            _calBurned = CalcCalories();

        }
        public override int CalcCalories()
        {
            return (int)(_distance * _avragePace * _calories);
        }
    }
}
