﻿using System;
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

        public Exercise()
        {
            this._name = "No Name";
            this._muscle = new Muscle();
        }

        public abstract double CalcCalories();

    }
    [Serializable]
    public class StrenghtExercise : Exercise
    {
        double _weight { get; set; }
        int _reps { get; set; }
        int _sets { get; set; }
        double _caloriesPerRep { get; set; }

        public StrenghtExercise()
        {
             type = 1;
            _weight = 0;
            _reps = 0;
            _sets = 0;
            _caloriesPerRep = 0;
        }
        public StrenghtExercise(double weight, int reps, int sets, double cal, string name,string muscle)
        {
            type = 1;
            _weight = weight;
            _reps = reps;
            _sets = sets;
            _caloriesPerRep = cal;
            _name = name;
            _muscle = new Muscle(muscle);
        }
        public override double CalcCalories()
        {
            return _reps * _sets * _caloriesPerRep;
        }
    }
    [Serializable]
    class StaminaExercise : Exercise
    {
        protected int _duration { get; set; }
        protected double _caloriesPerMin { get; set; }

        public StaminaExercise()
        {
            _duration = 0;
        }

        public override double CalcCalories()
        {
            return  _duration * _caloriesPerMin;
        }
    }
    [Serializable]
    class HIITExercise : StaminaExercise
    {
        int _intervalCount { get; set; }
        double _restTime { get; set; }
         int _intensity { get; set; }

        int _caloriesPerInterval { get; set; }

        public HIITExercise()
        {
            type = 2;
            _intervalCount = 0;
            _restTime = 0;
        }
        public HIITExercise(int cal, int numOfIntervals, double rest, int intensity,string name, string muscle)
        {
            type = 2;
            _intervalCount = numOfIntervals;
            _restTime = rest;
            _intensity = intensity;
            _caloriesPerInterval = cal;
            _name = name;
            _muscle = new Muscle(muscle);
        }
        public override double CalcCalories()
        {
            return _intervalCount * _caloriesPerInterval * _intensity;
        }
    }
    [Serializable]
    class EnduranceExercise : StaminaExercise
    {
        double _distance { get; set; }
        double _avragePace { get; set; }

        public EnduranceExercise()
        {
            type = 3;
            _distance = 0;
            _avragePace = 0;
        }
        public EnduranceExercise(double distance, double pace, string name, string muscle)
        {
            type = 3;
            _distance = 0;
            _avragePace = 0;
            _name = name;
            _muscle = new Muscle(muscle);
        }
        public override double CalcCalories()
        {
            return _distance * _avragePace * _caloriesPerMin;
        }
    }
}