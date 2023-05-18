
namespace winformsTEST
{
    partial class Mainform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.FirstPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this.topPanel = new System.Windows.Forms.Panel();
            this.Headline = new System.Windows.Forms.Label();
            this.Muscle1 = new System.Windows.Forms.Label();
            this.secPanel = new System.Windows.Forms.Panel();
            this.backgroundMusic = new AxWMPLib.AxWindowsMediaPlayer();
            this.background = new System.Windows.Forms.PictureBox();
            this.Sound = new System.Windows.Forms.Button();
            this.Minimize = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MyWorkouts = new System.Windows.Forms.Button();
            this.AboutUs = new System.Windows.Forms.Button();
            this.Videos = new System.Windows.Forms.Button();
            this.newWorkout = new System.Windows.Forms.Button();
            this.FirstPanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.secPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundMusic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(238, 48);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // FirstPanel
            // 
            this.FirstPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.FirstPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FirstPanel.Controls.Add(this.button5);
            this.FirstPanel.Controls.Add(this.pictureBox3);
            this.FirstPanel.Controls.Add(this.pictureBox2);
            this.FirstPanel.Controls.Add(this.pictureBox1);
            this.FirstPanel.Controls.Add(this.panel1);
            this.FirstPanel.Controls.Add(this.MyWorkouts);
            this.FirstPanel.Controls.Add(this.circularProgressBar1);
            this.FirstPanel.Controls.Add(this.AboutUs);
            this.FirstPanel.Controls.Add(this.Videos);
            this.FirstPanel.Controls.Add(this.newWorkout);
            this.FirstPanel.Controls.Add(this.tableLayoutPanel1);
            this.FirstPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.FirstPanel.Location = new System.Drawing.Point(0, 0);
            this.FirstPanel.Margin = new System.Windows.Forms.Padding(2);
            this.FirstPanel.Name = "FirstPanel";
            this.FirstPanel.Size = new System.Drawing.Size(233, 772);
            this.FirstPanel.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(232, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1051, 49);
            this.panel1.TabIndex = 0;
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.AnimationFunction = ((WinFormAnimation.AnimationFunctions.Function)(resources.GetObject("circularProgressBar1.AnimationFunction")));
            this.circularProgressBar1.AnimationSpeed = 500;
            this.circularProgressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.circularProgressBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.circularProgressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar1.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBar1.InnerMargin = 2;
            this.circularProgressBar1.InnerWidth = -1;
            this.circularProgressBar1.Location = new System.Drawing.Point(40, 546);
            this.circularProgressBar1.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.circularProgressBar1.OuterMargin = -25;
            this.circularProgressBar1.OuterWidth = 26;
            this.circularProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(139)))), ((int)(((byte)(201)))));
            this.circularProgressBar1.ProgressWidth = 10;
            this.circularProgressBar1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.circularProgressBar1.Size = new System.Drawing.Size(144, 144);
            this.circularProgressBar1.StartAngle = 270;
            this.circularProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.circularProgressBar1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar1.SubscriptText = "";
            this.circularProgressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar1.SuperscriptText = "";
            this.circularProgressBar1.TabIndex = 0;
            this.circularProgressBar1.Text = "Workouts";
            this.circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar1.Value = 68;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.topPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.topPanel.Controls.Add(this.Sound);
            this.topPanel.Controls.Add(this.Minimize);
            this.topPanel.Controls.Add(this.Exit);
            this.topPanel.Controls.Add(this.Headline);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topPanel.Location = new System.Drawing.Point(233, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(2);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1203, 772);
            this.topPanel.TabIndex = 0;
            // 
            // Headline
            // 
            this.Headline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.Headline.Dock = System.Windows.Forms.DockStyle.Top;
            this.Headline.Font = new System.Drawing.Font("Segoe Print", 11.525F, System.Drawing.FontStyle.Bold);
            this.Headline.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Headline.Location = new System.Drawing.Point(0, 0);
            this.Headline.Name = "Headline";
            this.Headline.Size = new System.Drawing.Size(1201, 49);
            this.Headline.TabIndex = 21;
            this.Headline.Text = "HOME";
            this.Headline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Muscle1
            // 
            this.Muscle1.AutoSize = true;
            this.Muscle1.Location = new System.Drawing.Point(287, 169);
            this.Muscle1.Name = "Muscle1";
            this.Muscle1.Size = new System.Drawing.Size(0, 13);
            this.Muscle1.TabIndex = 0;
            // 
            // secPanel
            // 
            this.secPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.secPanel.Controls.Add(this.backgroundMusic);
            this.secPanel.Controls.Add(this.background);
            this.secPanel.ForeColor = System.Drawing.SystemColors.Info;
            this.secPanel.Location = new System.Drawing.Point(233, 49);
            this.secPanel.Margin = new System.Windows.Forms.Padding(2);
            this.secPanel.Name = "secPanel";
            this.secPanel.Size = new System.Drawing.Size(1215, 721);
            this.secPanel.TabIndex = 14;
            // 
            // backgroundMusic
            // 
            this.backgroundMusic.Enabled = true;
            this.backgroundMusic.Location = new System.Drawing.Point(0, 695);
            this.backgroundMusic.Name = "backgroundMusic";
            this.backgroundMusic.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("backgroundMusic.OcxState")));
            this.backgroundMusic.Size = new System.Drawing.Size(75, 23);
            this.backgroundMusic.TabIndex = 21;
            // 
            // background
            // 
            this.background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.background.Image = ((System.Drawing.Image)(resources.GetObject("background.Image")));
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(1215, 721);
            this.background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.background.TabIndex = 20;
            this.background.TabStop = false;
            // 
            // Sound
            // 
            this.Sound.BackColor = System.Drawing.Color.Transparent;
            this.Sound.FlatAppearance.BorderSize = 0;
            this.Sound.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Sound.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Sound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sound.ForeColor = System.Drawing.Color.Transparent;
            this.Sound.Image = ((System.Drawing.Image)(resources.GetObject("Sound.Image")));
            this.Sound.Location = new System.Drawing.Point(21, 9);
            this.Sound.Name = "Sound";
            this.Sound.Size = new System.Drawing.Size(32, 32);
            this.Sound.TabIndex = 22;
            this.Sound.UseVisualStyleBackColor = false;
            this.Sound.Click += new System.EventHandler(this.Sound_Click);
            // 
            // Minimize
            // 
            this.Minimize.FlatAppearance.BorderSize = 0;
            this.Minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize.Image = ((System.Drawing.Image)(resources.GetObject("Minimize.Image")));
            this.Minimize.Location = new System.Drawing.Point(1126, 9);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(32, 32);
            this.Minimize.TabIndex = 22;
            this.Minimize.UseVisualStyleBackColor = true;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
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
            this.Exit.Location = new System.Drawing.Point(1164, 9);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(32, 32);
            this.Exit.TabIndex = 22;
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(139)))), ((int)(((byte)(201)))));
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe Print", 10.875F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button5.Location = new System.Drawing.Point(-1, -1);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(233, 157);
            this.button5.TabIndex = 35;
            this.button5.Text = "SHAPE SHIFT";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.Home_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(148, 704);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(58, 53);
            this.pictureBox3.TabIndex = 38;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(20, 704);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(58, 53);
            this.pictureBox2.TabIndex = 37;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(84, 704);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 53);
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // MyWorkouts
            // 
            this.MyWorkouts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.MyWorkouts.FlatAppearance.BorderSize = 0;
            this.MyWorkouts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(139)))), ((int)(((byte)(201)))));
            this.MyWorkouts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.MyWorkouts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MyWorkouts.Font = new System.Drawing.Font("Segoe Print", 11.875F, System.Drawing.FontStyle.Bold);
            this.MyWorkouts.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MyWorkouts.Image = ((System.Drawing.Image)(resources.GetObject("MyWorkouts.Image")));
            this.MyWorkouts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MyWorkouts.Location = new System.Drawing.Point(-1, 182);
            this.MyWorkouts.Name = "MyWorkouts";
            this.MyWorkouts.Size = new System.Drawing.Size(233, 85);
            this.MyWorkouts.TabIndex = 1;
            this.MyWorkouts.Text = "MY WORKOUTS";
            this.MyWorkouts.UseVisualStyleBackColor = false;
            this.MyWorkouts.Click += new System.EventHandler(this.myWorkouts_Click);
            // 
            // AboutUs
            // 
            this.AboutUs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.AboutUs.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.AboutUs.FlatAppearance.BorderSize = 0;
            this.AboutUs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(139)))), ((int)(((byte)(201)))));
            this.AboutUs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.AboutUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutUs.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold);
            this.AboutUs.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AboutUs.Image = ((System.Drawing.Image)(resources.GetObject("AboutUs.Image")));
            this.AboutUs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AboutUs.Location = new System.Drawing.Point(-1, 455);
            this.AboutUs.Name = "AboutUs";
            this.AboutUs.Size = new System.Drawing.Size(239, 85);
            this.AboutUs.TabIndex = 17;
            this.AboutUs.Text = "ABOUT US";
            this.AboutUs.UseVisualStyleBackColor = false;
            this.AboutUs.Click += new System.EventHandler(this.AboutUs_Click);
            // 
            // Videos
            // 
            this.Videos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.Videos.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.Videos.FlatAppearance.BorderSize = 0;
            this.Videos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(139)))), ((int)(((byte)(201)))));
            this.Videos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.Videos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Videos.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold);
            this.Videos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Videos.Image = ((System.Drawing.Image)(resources.GetObject("Videos.Image")));
            this.Videos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Videos.Location = new System.Drawing.Point(-1, 364);
            this.Videos.Name = "Videos";
            this.Videos.Size = new System.Drawing.Size(233, 85);
            this.Videos.TabIndex = 16;
            this.Videos.Text = "VIDEOS";
            this.Videos.UseVisualStyleBackColor = false;
            this.Videos.Click += new System.EventHandler(this.Videos_Click);
            // 
            // newWorkout
            // 
            this.newWorkout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.newWorkout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.newWorkout.FlatAppearance.BorderSize = 0;
            this.newWorkout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(139)))), ((int)(((byte)(201)))));
            this.newWorkout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.newWorkout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newWorkout.Font = new System.Drawing.Font("Segoe Print", 11.875F, System.Drawing.FontStyle.Bold);
            this.newWorkout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.newWorkout.Image = ((System.Drawing.Image)(resources.GetObject("newWorkout.Image")));
            this.newWorkout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newWorkout.Location = new System.Drawing.Point(-1, 273);
            this.newWorkout.Name = "newWorkout";
            this.newWorkout.Size = new System.Drawing.Size(233, 85);
            this.newWorkout.TabIndex = 2;
            this.newWorkout.Text = "NEW WORKOUT";
            this.newWorkout.UseVisualStyleBackColor = false;
            this.newWorkout.Click += new System.EventHandler(this.newWorkout_Click);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1436, 772);
            this.Controls.Add(this.secPanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.Muscle1);
            this.Controls.Add(this.FirstPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Mainform";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SHAPE SHIFT";
            this.FirstPanel.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.secPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.backgroundMusic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel FirstPanel;
        private System.Windows.Forms.Button AboutUs;
        private System.Windows.Forms.Button MyWorkouts;
        private System.Windows.Forms.Button Videos;
        private System.Windows.Forms.Button newWorkout;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label Muscle1;
        private CircularProgressBar.CircularProgressBar circularProgressBar1;
        public System.Windows.Forms.Panel secPanel;
        private System.Windows.Forms.PictureBox background;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Label Headline;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Minimize;
        private System.Windows.Forms.Button Sound;
        public AxWMPLib.AxWindowsMediaPlayer backgroundMusic;
    }
}

