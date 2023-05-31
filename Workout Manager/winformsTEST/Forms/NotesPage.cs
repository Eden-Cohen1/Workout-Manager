using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using winformsTEST.Class_s;
using System.Runtime.Serialization;//!!!!!!
using System.Runtime.Serialization.Formatters.Binary;

namespace winformsTEST.Forms
{
    public partial class NotesPage : UserControl
    {
        public static List<Notes> NotesList = new List<Notes>();
        public int x = 0;
        private TextBox lastFocused;

        public NotesPage()
        {
            InitializeComponent();
            foreach (Notes note in NotesList)
            {
                TextBox textbox = NotesUpdate(note._text, note);
                textbox.Location = new Point(100 + x, 250);
                x += textbox.Width/3;
            }
        }
        private void Shoulders_Click(object sender, EventArgs e)
        {

            Notes note = new Notes();
            TextBox textbox = NotesUpdate(headlineText.Text, note);
            textbox.Location = new Point(100, 250);
            textbox.BringToFront();
            NotesList.Add(note);
        }
        private TextBox NotesUpdate(string text, Notes note)
        {
            TextBox textbox = new TextBox();
            Controls.Add(textbox);
            textbox.Multiline = true;
            textbox.Size = new Size(250, 250);
            textbox.Text = text;
            ControlExtension.Draggable(textbox, true);
            textbox.Tag = note;
            textbox.LostFocus += textBoxFocusLost;
            textbox.TextChanged += textBoxChanged;
            textbox.BorderStyle = BorderStyle.FixedSingle;
            textbox.Text = text;
            textbox.Font = new Font("Segoe Print", 11, FontStyle.Bold);
            return textbox;
        }
        private void textBoxChanged(object sender, EventArgs e)
        {
            var tb = (TextBox)sender;
            var note = (Notes)tb.Tag;
            note._text = tb.Text;
        }

        private void textBoxFocusLost(object sender, EventArgs e)
        {
            lastFocused = (TextBox)sender;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(lastFocused != null)
            {
                Controls.Remove(lastFocused);
                NotesList.Remove((Notes)lastFocused.Tag);
                lastFocused = null;
            }
        }
    }
}
