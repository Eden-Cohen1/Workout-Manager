
namespace winformsTEST
{
    partial class AddWorkout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddWorkout));
            this.label1 = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.Duration = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.workoutAdded = new System.Windows.Forms.Label();
            this.addExercise = new System.Windows.Forms.Button();
            this.headline = new System.Windows.Forms.Label();
            this.DurationTextBox = new System.Windows.Forms.TextBox();
            this.typeDropDown = new System.Windows.Forms.FlowLayoutPanel();
            this.dropDown = new System.Windows.Forms.Button();
            this.StrenghtW = new System.Windows.Forms.Button();
            this.CardioW = new System.Windows.Forms.Button();
            this.woDropdown = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ExList = new System.Windows.Forms.ListBox();
            this.Exlistlabel = new System.Windows.Forms.Label();
            this.muscleList = new System.Windows.Forms.ListBox();
            this.typeDropDown.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(31, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Workout Name:";
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Description.Location = new System.Drawing.Point(33, 290);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(137, 33);
            this.Description.TabIndex = 2;
            this.Description.Text = "Description: ";
            // 
            // Duration
            // 
            this.Duration.AutoSize = true;
            this.Duration.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Duration.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Duration.Location = new System.Drawing.Point(33, 215);
            this.Duration.Name = "Duration";
            this.Duration.Size = new System.Drawing.Size(115, 33);
            this.Duration.TabIndex = 3;
            this.Duration.Text = "Duration: ";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(222, 151);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(217, 36);
            this.nameTextBox.TabIndex = 4;
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionTextBox.Location = new System.Drawing.Point(222, 290);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(217, 95);
            this.DescriptionTextBox.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(16, 557);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "DONE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // workoutAdded
            // 
            this.workoutAdded.AutoSize = true;
            this.workoutAdded.Enabled = false;
            this.workoutAdded.Font = new System.Drawing.Font("Segoe Print", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workoutAdded.ForeColor = System.Drawing.Color.DarkRed;
            this.workoutAdded.Location = new System.Drawing.Point(0, 624);
            this.workoutAdded.Name = "workoutAdded";
            this.workoutAdded.Size = new System.Drawing.Size(201, 33);
            this.workoutAdded.TabIndex = 9;
            this.workoutAdded.Text = "WORKOUT ADDED";
            this.workoutAdded.Visible = false;
            // 
            // addExercise
            // 
            this.addExercise.BackColor = System.Drawing.Color.RoyalBlue;
            this.addExercise.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addExercise.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addExercise.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addExercise.Location = new System.Drawing.Point(575, 134);
            this.addExercise.Name = "addExercise";
            this.addExercise.Size = new System.Drawing.Size(180, 51);
            this.addExercise.TabIndex = 11;
            this.addExercise.Text = "ADD EXERCISE";
            this.addExercise.UseVisualStyleBackColor = false;
            this.addExercise.Click += new System.EventHandler(this.button2_Click);
            // 
            // headline
            // 
            this.headline.AutoSize = true;
            this.headline.BackColor = System.Drawing.Color.Transparent;
            this.headline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.headline.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headline.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.headline.Location = new System.Drawing.Point(31, 59);
            this.headline.Name = "headline";
            this.headline.Size = new System.Drawing.Size(248, 47);
            this.headline.TabIndex = 12;
            this.headline.Text = "NEW WORKOUT";
            this.headline.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DurationTextBox
            // 
            this.DurationTextBox.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DurationTextBox.Location = new System.Drawing.Point(222, 222);
            this.DurationTextBox.Name = "DurationTextBox";
            this.DurationTextBox.Size = new System.Drawing.Size(217, 36);
            this.DurationTextBox.TabIndex = 13;
            // 
            // typeDropDown
            // 
            this.typeDropDown.Controls.Add(this.dropDown);
            this.typeDropDown.Controls.Add(this.StrenghtW);
            this.typeDropDown.Controls.Add(this.CardioW);
            this.typeDropDown.Location = new System.Drawing.Point(222, 425);
            this.typeDropDown.MaximumSize = new System.Drawing.Size(237, 109);
            this.typeDropDown.MinimumSize = new System.Drawing.Size(237, 33);
            this.typeDropDown.Name = "typeDropDown";
            this.typeDropDown.Size = new System.Drawing.Size(237, 109);
            this.typeDropDown.TabIndex = 21;
            // 
            // dropDown
            // 
            this.dropDown.BackColor = System.Drawing.SystemColors.Control;
            this.dropDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dropDown.BackgroundImage")));
            this.dropDown.Dock = System.Windows.Forms.DockStyle.Top;
            this.dropDown.FlatAppearance.BorderSize = 0;
            this.dropDown.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropDown.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dropDown.Image = ((System.Drawing.Image)(resources.GetObject("dropDown.Image")));
            this.dropDown.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dropDown.Location = new System.Drawing.Point(3, 3);
            this.dropDown.Name = "dropDown";
            this.dropDown.Size = new System.Drawing.Size(230, 30);
            this.dropDown.TabIndex = 12;
            this.dropDown.Text = "CHOOSE A TYPE";
            this.dropDown.UseVisualStyleBackColor = false;
            this.dropDown.Click += new System.EventHandler(this.dropDown_Click);
            // 
            // StrenghtW
            // 
            this.StrenghtW.Dock = System.Windows.Forms.DockStyle.Top;
            this.StrenghtW.FlatAppearance.BorderSize = 0;
            this.StrenghtW.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StrenghtW.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.StrenghtW.Location = new System.Drawing.Point(3, 39);
            this.StrenghtW.Name = "StrenghtW";
            this.StrenghtW.Size = new System.Drawing.Size(230, 30);
            this.StrenghtW.TabIndex = 13;
            this.StrenghtW.Text = "STRENGHT WORKOUT";
            this.StrenghtW.UseVisualStyleBackColor = true;
            this.StrenghtW.Click += new System.EventHandler(this.StrenghtW_Click);
            // 
            // CardioW
            // 
            this.CardioW.Dock = System.Windows.Forms.DockStyle.Top;
            this.CardioW.FlatAppearance.BorderSize = 0;
            this.CardioW.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardioW.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CardioW.Location = new System.Drawing.Point(3, 75);
            this.CardioW.Name = "CardioW";
            this.CardioW.Size = new System.Drawing.Size(230, 30);
            this.CardioW.TabIndex = 14;
            this.CardioW.Text = "CARDIO WORKOUT";
            this.CardioW.UseVisualStyleBackColor = true;
            this.CardioW.Click += new System.EventHandler(this.CardioW_Click);
            // 
            // woDropdown
            // 
            this.woDropdown.AutoSize = true;
            this.woDropdown.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.woDropdown.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.woDropdown.Location = new System.Drawing.Point(31, 425);
            this.woDropdown.Name = "woDropdown";
            this.woDropdown.Size = new System.Drawing.Size(158, 33);
            this.woDropdown.TabIndex = 20;
            this.woDropdown.Text = "Workout Type:";
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ExList
            // 
            this.ExList.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ExList.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExList.FormattingEnabled = true;
            this.ExList.ItemHeight = 28;
            this.ExList.Items.AddRange(new object[] {
            "EXERCISE NAME"});
            this.ExList.Location = new System.Drawing.Point(694, 211);
            this.ExList.Name = "ExList";
            this.ExList.Size = new System.Drawing.Size(217, 228);
            this.ExList.TabIndex = 23;
            // 
            // Exlistlabel
            // 
            this.Exlistlabel.AutoSize = true;
            this.Exlistlabel.BackColor = System.Drawing.Color.Transparent;
            this.Exlistlabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exlistlabel.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exlistlabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Exlistlabel.Location = new System.Drawing.Point(567, 59);
            this.Exlistlabel.Name = "Exlistlabel";
            this.Exlistlabel.Size = new System.Drawing.Size(231, 47);
            this.Exlistlabel.TabIndex = 24;
            this.Exlistlabel.Text = "EXERCISE LIST";
            this.Exlistlabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // muscleList
            // 
            this.muscleList.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.muscleList.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.muscleList.FormattingEnabled = true;
            this.muscleList.ItemHeight = 28;
            this.muscleList.Items.AddRange(new object[] {
            "MUSCLE"});
            this.muscleList.Location = new System.Drawing.Point(575, 211);
            this.muscleList.Name = "muscleList";
            this.muscleList.Size = new System.Drawing.Size(115, 228);
            this.muscleList.TabIndex = 25;
            // 
            // AddWorkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(56)))));
            this.Controls.Add(this.muscleList);
            this.Controls.Add(this.Exlistlabel);
            this.Controls.Add(this.ExList);
            this.Controls.Add(this.typeDropDown);
            this.Controls.Add(this.woDropdown);
            this.Controls.Add(this.DurationTextBox);
            this.Controls.Add(this.headline);
            this.Controls.Add(this.addExercise);
            this.Controls.Add(this.workoutAdded);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.Duration);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.label1);
            this.Name = "AddWorkout";
            this.Size = new System.Drawing.Size(973, 673);
            this.typeDropDown.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label Duration;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label workoutAdded;
        private System.Windows.Forms.Button addExercise;
        private System.Windows.Forms.Label headline;
        private System.Windows.Forms.TextBox DurationTextBox;
        private System.Windows.Forms.FlowLayoutPanel typeDropDown;
        private System.Windows.Forms.Button dropDown;
        private System.Windows.Forms.Button StrenghtW;
        private System.Windows.Forms.Button CardioW;
        private System.Windows.Forms.Label woDropdown;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.ListBox ExList;
        private System.Windows.Forms.Label Exlistlabel;
        public System.Windows.Forms.ListBox muscleList;
    }
}