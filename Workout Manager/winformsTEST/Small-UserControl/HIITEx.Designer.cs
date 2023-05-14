
namespace winformsTEST
{
    partial class HIITEx
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HIITEx));
            this.intrcountTextBox = new System.Windows.Forms.TextBox();
            this.intenseDropDown = new System.Windows.Forms.FlowLayoutPanel();
            this.Easy = new System.Windows.Forms.Button();
            this.Medium = new System.Windows.Forms.Button();
            this.Hard = new System.Windows.Forms.Button();
            this.numOfIntervals = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.restTextBox = new System.Windows.Forms.TextBox();
            this.restTime = new System.Windows.Forms.Label();
            this.intensityDropDown = new System.Windows.Forms.Button();
            this.intenseDropDown.SuspendLayout();
            this.SuspendLayout();
            // 
            // intrcountTextBox
            // 
            this.intrcountTextBox.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.intrcountTextBox.Location = new System.Drawing.Point(248, 32);
            this.intrcountTextBox.Name = "intrcountTextBox";
            this.intrcountTextBox.Size = new System.Drawing.Size(173, 36);
            this.intrcountTextBox.TabIndex = 26;
            this.intrcountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.intrcountTextBox_KeyPress);
            // 
            // intenseDropDown
            // 
            this.intenseDropDown.Controls.Add(this.intensityDropDown);
            this.intenseDropDown.Controls.Add(this.Easy);
            this.intenseDropDown.Controls.Add(this.Medium);
            this.intenseDropDown.Controls.Add(this.Hard);
            this.intenseDropDown.Location = new System.Drawing.Point(211, 180);
            this.intenseDropDown.MaximumSize = new System.Drawing.Size(237, 140);
            this.intenseDropDown.MinimumSize = new System.Drawing.Size(237, 33);
            this.intenseDropDown.Name = "intenseDropDown";
            this.intenseDropDown.Size = new System.Drawing.Size(237, 35);
            this.intenseDropDown.TabIndex = 25;
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
            // numOfIntervals
            // 
            this.numOfIntervals.AutoSize = true;
            this.numOfIntervals.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOfIntervals.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.numOfIntervals.Location = new System.Drawing.Point(24, 35);
            this.numOfIntervals.Name = "numOfIntervals";
            this.numOfIntervals.Size = new System.Drawing.Size(218, 33);
            this.numOfIntervals.TabIndex = 24;
            this.numOfIntervals.Text = "Number Of Intervals:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(24, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 33);
            this.label1.TabIndex = 23;
            this.label1.Text = "Intensity: ";
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // restTextBox
            // 
            this.restTextBox.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.restTextBox.Location = new System.Drawing.Point(248, 97);
            this.restTextBox.Name = "restTextBox";
            this.restTextBox.Size = new System.Drawing.Size(173, 36);
            this.restTextBox.TabIndex = 27;
            this.restTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.restTextBox_KeyPress);
            // 
            // restTime
            // 
            this.restTime.AutoSize = true;
            this.restTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.restTime.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restTime.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.restTime.Location = new System.Drawing.Point(24, 100);
            this.restTime.Name = "restTime";
            this.restTime.Size = new System.Drawing.Size(146, 33);
            this.restTime.TabIndex = 28;
            this.restTime.Text = "Resting Time:";
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
            // HIITEx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.Controls.Add(this.restTextBox);
            this.Controls.Add(this.restTime);
            this.Controls.Add(this.intrcountTextBox);
            this.Controls.Add(this.intenseDropDown);
            this.Controls.Add(this.numOfIntervals);
            this.Controls.Add(this.label1);
            this.Name = "HIITEx";
            this.Size = new System.Drawing.Size(456, 316);
            this.intenseDropDown.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel intenseDropDown;
        private System.Windows.Forms.Label numOfIntervals;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Hard;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button intensityDropDown;
        private System.Windows.Forms.Button Easy;
        private System.Windows.Forms.Button Medium;
        private System.Windows.Forms.Label restTime;
        public System.Windows.Forms.TextBox intrcountTextBox;
        public System.Windows.Forms.TextBox restTextBox;
    }
}
