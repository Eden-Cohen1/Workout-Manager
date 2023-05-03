
namespace winformsTEST
{
    partial class Form1
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
            this.Muscle1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.newWorkout = new System.Windows.Forms.Button();
            this.headline = new System.Windows.Forms.Label();
            this.secPanel = new System.Windows.Forms.Panel();
            this.topPanel = new System.Windows.Forms.Panel();
            this.Home = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.FirstPanel = new System.Windows.Forms.Panel();
            this.topPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.FirstPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Muscle1
            // 
            this.Muscle1.AutoSize = true;
            this.Muscle1.Location = new System.Drawing.Point(574, 325);
            this.Muscle1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Muscle1.Name = "Muscle1";
            this.Muscle1.Size = new System.Drawing.Size(0, 25);
            this.Muscle1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe Print", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(0, 250);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(470, 171);
            this.button1.TabIndex = 1;
            this.button1.Text = "MY WORKOUT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // newWorkout
            // 
            this.newWorkout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.newWorkout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.newWorkout.FlatAppearance.BorderSize = 0;
            this.newWorkout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.newWorkout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.newWorkout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newWorkout.Font = new System.Drawing.Font("Segoe Print", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newWorkout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.newWorkout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.newWorkout.Location = new System.Drawing.Point(0, 452);
            this.newWorkout.Margin = new System.Windows.Forms.Padding(6);
            this.newWorkout.Name = "newWorkout";
            this.newWorkout.Size = new System.Drawing.Size(470, 171);
            this.newWorkout.TabIndex = 2;
            this.newWorkout.Text = "NEW WORKOUT";
            this.newWorkout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.newWorkout.UseVisualStyleBackColor = false;
            this.newWorkout.Click += new System.EventHandler(this.newWorkout_Click);
            // 
            // headline
            // 
            this.headline.AutoSize = true;
            this.headline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(56)))));
            this.headline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.headline.Font = new System.Drawing.Font("Segoe Print", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headline.ForeColor = System.Drawing.Color.White;
            this.headline.Location = new System.Drawing.Point(2, 52);
            this.headline.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.headline.Name = "headline";
            this.headline.Size = new System.Drawing.Size(452, 65);
            this.headline.TabIndex = 13;
            this.headline.Text = "WORKOUT MANAGER";
            this.headline.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // secPanel
            // 
            this.secPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.secPanel.BackColor = System.Drawing.SystemColors.Menu;
            this.secPanel.ForeColor = System.Drawing.SystemColors.Info;
            this.secPanel.Location = new System.Drawing.Point(476, 156);
            this.secPanel.Margin = new System.Windows.Forms.Padding(4);
            this.secPanel.Name = "secPanel";
            this.secPanel.Size = new System.Drawing.Size(2148, 1331);
            this.secPanel.TabIndex = 14;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.topPanel.Controls.Add(this.Home);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(476, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(4);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1424, 162);
            this.topPanel.TabIndex = 0;
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.RoyalBlue;
            this.Home.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Home.FlatAppearance.BorderSize = 0;
            this.Home.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Home.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home.Font = new System.Drawing.Font("Segoe Print", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Home.Location = new System.Drawing.Point(0, 0);
            this.Home.Margin = new System.Windows.Forms.Padding(6);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(1424, 162);
            this.Home.TabIndex = 18;
            this.Home.Text = "HOME";
            this.Home.UseVisualStyleBackColor = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(56)))));
            this.panel2.Controls.Add(this.headline);
            this.panel2.Location = new System.Drawing.Point(4, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(464, 162);
            this.panel2.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(6, 654);
            this.button2.Margin = new System.Windows.Forms.Padding(6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(470, 171);
            this.button2.TabIndex = 16;
            this.button2.Text = "VIDEOS";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(8, 858);
            this.button3.Margin = new System.Windows.Forms.Padding(6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(470, 171);
            this.button3.TabIndex = 17;
            this.button3.Text = "ABOUT US";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // FirstPanel
            // 
            this.FirstPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.FirstPanel.Controls.Add(this.button3);
            this.FirstPanel.Controls.Add(this.button1);
            this.FirstPanel.Controls.Add(this.button2);
            this.FirstPanel.Controls.Add(this.newWorkout);
            this.FirstPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.FirstPanel.Location = new System.Drawing.Point(0, 0);
            this.FirstPanel.Margin = new System.Windows.Forms.Padding(4);
            this.FirstPanel.Name = "FirstPanel";
            this.FirstPanel.Size = new System.Drawing.Size(476, 1135);
            this.FirstPanel.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1900, 1135);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.secPanel);
            this.Controls.Add(this.Muscle1);
            this.Controls.Add(this.FirstPanel);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Form1";
            this.topPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.FirstPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Muscle1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button newWorkout;
        private System.Windows.Forms.Label headline;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel FirstPanel;
        public System.Windows.Forms.Panel secPanel;
    }
}

