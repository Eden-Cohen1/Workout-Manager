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
    public partial class HIITEx : UserControl
    {
        public static HIITEx instance;
        private bool isCollapsed; //for the dropdown menu

        public HIITEx()
        {
            InitializeComponent();
            instance = this;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void intensityDropDown_Click(object sender, EventArgs e)
        {
            timer1.Start();

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
                if (isCollapsed)
                {
                    intenseDropDown.Height += 10;
                    if (intenseDropDown.Size == intenseDropDown.MaximumSize)
                    {
                        timer1.Stop();
                        isCollapsed = false;
                    }
                }
                else
                {
                    intenseDropDown.Height -= 10;
                    if (intenseDropDown.Size == intenseDropDown.MinimumSize)
                    {
                        timer1.Stop();
                        isCollapsed = true;
                    }
                }
            }

        private void Easy_Click(object sender, EventArgs e)
        {
            timer1.Start();
            intensityDropDown.Text = Easy.Text;
            AddEx.instance.Intensity = 1; // setting intensity level for adding the exercise
        }

        private void Medium_Click(object sender, EventArgs e)
        {
            timer1.Start();
            intensityDropDown.Text = Medium.Text;
            AddEx.instance.Intensity = 2;

        }

        private void Hard_Click(object sender, EventArgs e)
        {
            timer1.Start();
            intensityDropDown.Text = Hard.Text;
            AddEx.instance.Intensity = 3;

        }

        private void intrcountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void restTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
    }

