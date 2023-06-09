﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;//!!!!!!
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using winformsTEST.Class_s;
using winformsTEST.Forms;

namespace winformsTEST
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (File.Exists("main_file") && new FileInfo("main_file").Length != 0)
            {
                Stream stream = File.Open("main_file", FileMode.Open);
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                //!!!!
                AddWorkout.workout_list = (List<Workout>)binaryFormatter.Deserialize(stream);
                stream.Close();

            }

            if (File.Exists("notes_file") && new FileInfo("notes_file").Length != 0)
            {
                Stream stream = File.Open("notes_file", FileMode.Open);
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                //!!!!
                NotesPage.NotesList = (List<Notes>)binaryFormatter.Deserialize(stream);
                stream.Close();

            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Mainform());
        }
    }
}
