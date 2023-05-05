using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winformsTEST
{
    public partial class myWorkouts : UserControl
    {
        public static myWorkouts instance;

        public myWorkouts()
        {
            InitializeComponent();
            instance = this;
        }

        private void myWorkouts_Load(object sender, EventArgs e)
        {

        }


        private void ViewWorkout_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in myWorkoutsList.Items)
            {
                if (item.Selected == true)
                {
                    WorkoutPage screen = new WorkoutPage();
                    Form1.instance.secPanel.Controls.Add(screen);
                    screen.BringToFront();
                }
            }
        }
    }
}
//for testing

/*                    Label testlabel = new Label();
                    Form1.instance.secPanel.Controls.Add(testlabel);
                    testlabel.BringToFront();
                    testlabel.Size = new Size(700, 700);*/