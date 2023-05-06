
namespace winformsTEST
{
    partial class EditEx
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditEx));
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.muscleTextBox = new System.Windows.Forms.TextBox();
            this.exMuscleLable = new System.Windows.Forms.Label();
            this.exNameLable = new System.Windows.Forms.Label();
            this.restTextBox = new System.Windows.Forms.TextBox();
            this.restTime = new System.Windows.Forms.Label();
            this.intenseDropDown = new System.Windows.Forms.FlowLayoutPanel();
            this.intensityDropDown = new System.Windows.Forms.Button();
            this.Easy = new System.Windows.Forms.Button();
            this.Medium = new System.Windows.Forms.Button();
            this.Hard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.setsTextBox = new System.Windows.Forms.TextBox();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.repTextBox = new System.Windows.Forms.TextBox();
            this.exRepsLable = new System.Windows.Forms.Label();
            this.exSetsLable = new System.Windows.Forms.Label();
            this.exWeightLable = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PaceTextBox = new System.Windows.Forms.TextBox();
            this.distanceTextBox = new System.Windows.Forms.TextBox();
            this.Distance = new System.Windows.Forms.Label();
            this.avragePace = new System.Windows.Forms.Label();
            this.SaveChanges = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Minimize = new System.Windows.Forms.Button();
            this.intenseDropDown.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.nameTextBox.Location = new System.Drawing.Point(209, 32);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(173, 36);
            this.nameTextBox.TabIndex = 25;
            // 
            // muscleTextBox
            // 
            this.muscleTextBox.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.muscleTextBox.Location = new System.Drawing.Point(209, 104);
            this.muscleTextBox.Name = "muscleTextBox";
            this.muscleTextBox.Size = new System.Drawing.Size(173, 36);
            this.muscleTextBox.TabIndex = 24;
            // 
            // exMuscleLable
            // 
            this.exMuscleLable.AutoSize = true;
            this.exMuscleLable.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exMuscleLable.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.exMuscleLable.Location = new System.Drawing.Point(19, 109);
            this.exMuscleLable.Name = "exMuscleLable";
            this.exMuscleLable.Size = new System.Drawing.Size(152, 33);
            this.exMuscleLable.TabIndex = 23;
            this.exMuscleLable.Text = "Muscle Group:";
            // 
            // exNameLable
            // 
            this.exNameLable.AutoSize = true;
            this.exNameLable.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exNameLable.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.exNameLable.Location = new System.Drawing.Point(19, 33);
            this.exNameLable.Name = "exNameLable";
            this.exNameLable.Size = new System.Drawing.Size(160, 33);
            this.exNameLable.TabIndex = 22;
            this.exNameLable.Text = "Exercise Name:";
            // 
            // restTextBox
            // 
            this.restTextBox.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.restTextBox.Location = new System.Drawing.Point(737, 34);
            this.restTextBox.Name = "restTextBox";
            this.restTextBox.Size = new System.Drawing.Size(173, 36);
            this.restTextBox.TabIndex = 37;
            // 
            // restTime
            // 
            this.restTime.AutoSize = true;
            this.restTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.restTime.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restTime.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.restTime.Location = new System.Drawing.Point(513, 37);
            this.restTime.Name = "restTime";
            this.restTime.Size = new System.Drawing.Size(146, 33);
            this.restTime.TabIndex = 36;
            this.restTime.Text = "Resting Time:";
            // 
            // intenseDropDown
            // 
            this.intenseDropDown.Controls.Add(this.intensityDropDown);
            this.intenseDropDown.Controls.Add(this.Easy);
            this.intenseDropDown.Controls.Add(this.Medium);
            this.intenseDropDown.Controls.Add(this.Hard);
            this.intenseDropDown.Location = new System.Drawing.Point(700, 117);
            this.intenseDropDown.MaximumSize = new System.Drawing.Size(237, 140);
            this.intenseDropDown.MinimumSize = new System.Drawing.Size(237, 33);
            this.intenseDropDown.Name = "intenseDropDown";
            this.intenseDropDown.Size = new System.Drawing.Size(237, 35);
            this.intenseDropDown.TabIndex = 33;
            // 
            // intensityDropDown
            // 
            this.intensityDropDown.BackColor = System.Drawing.SystemColors.Control;
            this.intensityDropDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("intensityDropDown.BackgroundImage")));
            this.intensityDropDown.Dock = System.Windows.Forms.DockStyle.Top;
            this.intensityDropDown.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intensityDropDown.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.intensityDropDown.Image = ((System.Drawing.Image)(resources.GetObject("intensityDropDown.Image")));
            this.intensityDropDown.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.intensityDropDown.Location = new System.Drawing.Point(3, 3);
            this.intensityDropDown.Name = "intensityDropDown";
            this.intensityDropDown.Size = new System.Drawing.Size(230, 30);
            this.intensityDropDown.TabIndex = 12;
            this.intensityDropDown.Text = "Choose Intensity";
            this.intensityDropDown.UseVisualStyleBackColor = false;
            this.intensityDropDown.Click += new System.EventHandler(this.intensityDropDown_Click);
            // 
            // Easy
            // 
            this.Easy.Dock = System.Windows.Forms.DockStyle.Top;
            this.Easy.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Easy.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Easy.Location = new System.Drawing.Point(3, 39);
            this.Easy.Name = "Easy";
            this.Easy.Size = new System.Drawing.Size(230, 30);
            this.Easy.TabIndex = 13;
            this.Easy.Text = "Easy";
            this.Easy.UseVisualStyleBackColor = true;
            this.Easy.Click += new System.EventHandler(this.Easy_Click);
            // 
            // Medium
            // 
            this.Medium.Dock = System.Windows.Forms.DockStyle.Top;
            this.Medium.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Medium.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Medium.Location = new System.Drawing.Point(3, 75);
            this.Medium.Name = "Medium";
            this.Medium.Size = new System.Drawing.Size(230, 30);
            this.Medium.TabIndex = 14;
            this.Medium.Text = "Medium";
            this.Medium.UseVisualStyleBackColor = true;
            this.Medium.Click += new System.EventHandler(this.Medium_Click);
            // 
            // Hard
            // 
            this.Hard.Dock = System.Windows.Forms.DockStyle.Top;
            this.Hard.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hard.Location = new System.Drawing.Point(3, 111);
            this.Hard.Name = "Hard";
            this.Hard.Size = new System.Drawing.Size(230, 30);
            this.Hard.TabIndex = 15;
            this.Hard.Text = "Hard";
            this.Hard.UseVisualStyleBackColor = true;
            this.Hard.Click += new System.EventHandler(this.Hard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(513, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 33);
            this.label1.TabIndex = 31;
            this.label1.Text = "Intensity: ";
            // 
            // setsTextBox
            // 
            this.setsTextBox.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.setsTextBox.Location = new System.Drawing.Point(209, 266);
            this.setsTextBox.Name = "setsTextBox";
            this.setsTextBox.Size = new System.Drawing.Size(173, 36);
            this.setsTextBox.TabIndex = 43;
            // 
            // weightTextBox
            // 
            this.weightTextBox.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.weightTextBox.Location = new System.Drawing.Point(209, 349);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(173, 36);
            this.weightTextBox.TabIndex = 42;
            // 
            // repTextBox
            // 
            this.repTextBox.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.repTextBox.Location = new System.Drawing.Point(209, 186);
            this.repTextBox.Name = "repTextBox";
            this.repTextBox.Size = new System.Drawing.Size(173, 36);
            this.repTextBox.TabIndex = 41;
            // 
            // exRepsLable
            // 
            this.exRepsLable.AutoSize = true;
            this.exRepsLable.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exRepsLable.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.exRepsLable.Location = new System.Drawing.Point(19, 193);
            this.exRepsLable.Name = "exRepsLable";
            this.exRepsLable.Size = new System.Drawing.Size(127, 33);
            this.exRepsLable.TabIndex = 40;
            this.exRepsLable.Text = "Repetitions:";
            // 
            // exSetsLable
            // 
            this.exSetsLable.AutoSize = true;
            this.exSetsLable.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exSetsLable.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.exSetsLable.Location = new System.Drawing.Point(19, 273);
            this.exSetsLable.Name = "exSetsLable";
            this.exSetsLable.Size = new System.Drawing.Size(60, 33);
            this.exSetsLable.TabIndex = 39;
            this.exSetsLable.Text = "Sets:";
            // 
            // exWeightLable
            // 
            this.exWeightLable.AutoSize = true;
            this.exWeightLable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.exWeightLable.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exWeightLable.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.exWeightLable.Location = new System.Drawing.Point(22, 352);
            this.exWeightLable.Name = "exWeightLable";
            this.exWeightLable.Size = new System.Drawing.Size(87, 33);
            this.exWeightLable.TabIndex = 38;
            this.exWeightLable.Text = "Weight:";
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PaceTextBox
            // 
            this.PaceTextBox.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.PaceTextBox.Location = new System.Drawing.Point(794, 337);
            this.PaceTextBox.Name = "PaceTextBox";
            this.PaceTextBox.Size = new System.Drawing.Size(101, 36);
            this.PaceTextBox.TabIndex = 47;
            // 
            // distanceTextBox
            // 
            this.distanceTextBox.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.distanceTextBox.Location = new System.Drawing.Point(794, 274);
            this.distanceTextBox.Name = "distanceTextBox";
            this.distanceTextBox.Size = new System.Drawing.Size(102, 36);
            this.distanceTextBox.TabIndex = 46;
            // 
            // Distance
            // 
            this.Distance.AutoSize = true;
            this.Distance.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Distance.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Distance.Location = new System.Drawing.Point(513, 277);
            this.Distance.Name = "Distance";
            this.Distance.Size = new System.Drawing.Size(102, 33);
            this.Distance.TabIndex = 45;
            this.Distance.Text = "Distance:";
            // 
            // avragePace
            // 
            this.avragePace.AutoSize = true;
            this.avragePace.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avragePace.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.avragePace.Location = new System.Drawing.Point(513, 336);
            this.avragePace.Name = "avragePace";
            this.avragePace.Size = new System.Drawing.Size(275, 33);
            this.avragePace.TabIndex = 44;
            this.avragePace.Text = "Average Pace (in minutes):";
            // 
            // SaveChanges
            // 
            this.SaveChanges.BackColor = System.Drawing.Color.RoyalBlue;
            this.SaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveChanges.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveChanges.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SaveChanges.Location = new System.Drawing.Point(32, 466);
            this.SaveChanges.Name = "SaveChanges";
            this.SaveChanges.Size = new System.Drawing.Size(147, 40);
            this.SaveChanges.TabIndex = 48;
            this.SaveChanges.Text = "Save Changes";
            this.SaveChanges.UseVisualStyleBackColor = false;
            this.SaveChanges.Click += new System.EventHandler(this.SaveChanges_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.ForeColor = System.Drawing.Color.Transparent;
            this.Exit.Image = ((System.Drawing.Image)(resources.GetObject("Exit.Image")));
            this.Exit.Location = new System.Drawing.Point(1031, 1);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(32, 32);
            this.Exit.TabIndex = 49;
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Minimize
            // 
            this.Minimize.FlatAppearance.BorderSize = 0;
            this.Minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize.Image = ((System.Drawing.Image)(resources.GetObject("Minimize.Image")));
            this.Minimize.Location = new System.Drawing.Point(993, 1);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(32, 32);
            this.Minimize.TabIndex = 50;
            this.Minimize.UseVisualStyleBackColor = true;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // EditEx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(1061, 556);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.SaveChanges);
            this.Controls.Add(this.PaceTextBox);
            this.Controls.Add(this.distanceTextBox);
            this.Controls.Add(this.Distance);
            this.Controls.Add(this.avragePace);
            this.Controls.Add(this.setsTextBox);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(this.repTextBox);
            this.Controls.Add(this.exRepsLable);
            this.Controls.Add(this.exSetsLable);
            this.Controls.Add(this.exWeightLable);
            this.Controls.Add(this.restTextBox);
            this.Controls.Add(this.restTime);
            this.Controls.Add(this.intenseDropDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.muscleTextBox);
            this.Controls.Add(this.exMuscleLable);
            this.Controls.Add(this.exNameLable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditEx";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditEx";
            this.intenseDropDown.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label exMuscleLable;
        private System.Windows.Forms.Label exNameLable;
        public System.Windows.Forms.TextBox restTextBox;
        private System.Windows.Forms.Label restTime;
        private System.Windows.Forms.Button intensityDropDown;
        private System.Windows.Forms.Button Easy;
        private System.Windows.Forms.Button Medium;
        private System.Windows.Forms.Button Hard;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox setsTextBox;
        public System.Windows.Forms.TextBox weightTextBox;
        public System.Windows.Forms.TextBox repTextBox;
        private System.Windows.Forms.Label exRepsLable;
        private System.Windows.Forms.Label exSetsLable;
        private System.Windows.Forms.Label exWeightLable;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.TextBox PaceTextBox;
        public System.Windows.Forms.TextBox distanceTextBox;
        private System.Windows.Forms.Label Distance;
        private System.Windows.Forms.Label avragePace;
        public System.Windows.Forms.FlowLayoutPanel intenseDropDown;
        public System.Windows.Forms.TextBox nameTextBox;
        public System.Windows.Forms.TextBox muscleTextBox;
        private System.Windows.Forms.Button SaveChanges;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Minimize;
    }
}