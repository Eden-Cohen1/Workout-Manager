
namespace winformsTEST.Forms
{
    partial class Videos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Videos));
            this.VideoPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.Tricep = new System.Windows.Forms.Button();
            this.Chest = new System.Windows.Forms.Button();
            this.Shoulders = new System.Windows.Forms.Button();
            this.Biceps = new System.Windows.Forms.Button();
            this.Hamstrings = new System.Windows.Forms.Button();
            this.LowerBack = new System.Windows.Forms.Button();
            this.UpperBack = new System.Windows.Forms.Button();
            this.Quads = new System.Windows.Forms.Button();
            this.ChooseMuscleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.VideoPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // VideoPlayer
            // 
            this.VideoPlayer.Enabled = true;
            this.VideoPlayer.Location = new System.Drawing.Point(243, 89);
            this.VideoPlayer.Name = "VideoPlayer";
            this.VideoPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("VideoPlayer.OcxState")));
            this.VideoPlayer.Size = new System.Drawing.Size(874, 581);
            this.VideoPlayer.TabIndex = 0;
            // 
            // Tricep
            // 
            this.Tricep.BackColor = System.Drawing.Color.RoyalBlue;
            this.Tricep.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Tricep.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tricep.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Tricep.Location = new System.Drawing.Point(43, 240);
            this.Tricep.Name = "Tricep";
            this.Tricep.Size = new System.Drawing.Size(158, 48);
            this.Tricep.TabIndex = 9;
            this.Tricep.TabStop = false;
            this.Tricep.Text = "Triceps";
            this.Tricep.UseVisualStyleBackColor = false;
            this.Tricep.Click += new System.EventHandler(this.Tricep_Click);
            // 
            // Chest
            // 
            this.Chest.BackColor = System.Drawing.Color.RoyalBlue;
            this.Chest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Chest.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chest.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Chest.Location = new System.Drawing.Point(43, 164);
            this.Chest.Name = "Chest";
            this.Chest.Size = new System.Drawing.Size(158, 48);
            this.Chest.TabIndex = 10;
            this.Chest.TabStop = false;
            this.Chest.Text = "Chest";
            this.Chest.UseVisualStyleBackColor = false;
            this.Chest.Click += new System.EventHandler(this.Chest_Click);
            // 
            // Shoulders
            // 
            this.Shoulders.BackColor = System.Drawing.Color.RoyalBlue;
            this.Shoulders.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Shoulders.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Shoulders.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Shoulders.Location = new System.Drawing.Point(44, 89);
            this.Shoulders.Name = "Shoulders";
            this.Shoulders.Size = new System.Drawing.Size(158, 48);
            this.Shoulders.TabIndex = 11;
            this.Shoulders.TabStop = false;
            this.Shoulders.Text = "Shoulders";
            this.Shoulders.UseVisualStyleBackColor = false;
            this.Shoulders.Click += new System.EventHandler(this.button2_Click);
            // 
            // Biceps
            // 
            this.Biceps.BackColor = System.Drawing.Color.RoyalBlue;
            this.Biceps.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Biceps.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Biceps.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Biceps.Location = new System.Drawing.Point(43, 317);
            this.Biceps.Name = "Biceps";
            this.Biceps.Size = new System.Drawing.Size(158, 48);
            this.Biceps.TabIndex = 12;
            this.Biceps.TabStop = false;
            this.Biceps.Text = "Biceps";
            this.Biceps.UseVisualStyleBackColor = false;
            this.Biceps.Click += new System.EventHandler(this.Biceps_Click);
            // 
            // Hamstrings
            // 
            this.Hamstrings.BackColor = System.Drawing.Color.RoyalBlue;
            this.Hamstrings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Hamstrings.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hamstrings.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Hamstrings.Location = new System.Drawing.Point(43, 622);
            this.Hamstrings.Name = "Hamstrings";
            this.Hamstrings.Size = new System.Drawing.Size(158, 48);
            this.Hamstrings.TabIndex = 16;
            this.Hamstrings.TabStop = false;
            this.Hamstrings.Text = "Hamstrings";
            this.Hamstrings.UseVisualStyleBackColor = false;
            this.Hamstrings.Click += new System.EventHandler(this.Hamstrings_Click);
            // 
            // LowerBack
            // 
            this.LowerBack.BackColor = System.Drawing.Color.RoyalBlue;
            this.LowerBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LowerBack.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LowerBack.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LowerBack.Location = new System.Drawing.Point(44, 394);
            this.LowerBack.Name = "LowerBack";
            this.LowerBack.Size = new System.Drawing.Size(158, 48);
            this.LowerBack.TabIndex = 15;
            this.LowerBack.TabStop = false;
            this.LowerBack.Text = "Lower Back";
            this.LowerBack.UseVisualStyleBackColor = false;
            this.LowerBack.Click += new System.EventHandler(this.LowerBack_Click);
            // 
            // UpperBack
            // 
            this.UpperBack.BackColor = System.Drawing.Color.RoyalBlue;
            this.UpperBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UpperBack.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpperBack.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.UpperBack.Location = new System.Drawing.Point(43, 472);
            this.UpperBack.Name = "UpperBack";
            this.UpperBack.Size = new System.Drawing.Size(158, 48);
            this.UpperBack.TabIndex = 14;
            this.UpperBack.TabStop = false;
            this.UpperBack.Text = "Upper Back";
            this.UpperBack.UseVisualStyleBackColor = false;
            this.UpperBack.Click += new System.EventHandler(this.UpperBack_Click);
            // 
            // Quads
            // 
            this.Quads.BackColor = System.Drawing.Color.RoyalBlue;
            this.Quads.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Quads.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quads.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Quads.Location = new System.Drawing.Point(44, 550);
            this.Quads.Name = "Quads";
            this.Quads.Size = new System.Drawing.Size(158, 48);
            this.Quads.TabIndex = 13;
            this.Quads.TabStop = false;
            this.Quads.Text = "Quads";
            this.Quads.UseVisualStyleBackColor = false;
            this.Quads.Click += new System.EventHandler(this.Quads_Click);
            // 
            // ChooseMuscleLabel
            // 
            this.ChooseMuscleLabel.AutoSize = true;
            this.ChooseMuscleLabel.Font = new System.Drawing.Font("Segoe Print", 13F, System.Drawing.FontStyle.Bold);
            this.ChooseMuscleLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ChooseMuscleLabel.Location = new System.Drawing.Point(3, 14);
            this.ChooseMuscleLabel.Name = "ChooseMuscleLabel";
            this.ChooseMuscleLabel.Size = new System.Drawing.Size(268, 62);
            this.ChooseMuscleLabel.TabIndex = 23;
            this.ChooseMuscleLabel.Text = "Choose a muscle group and \r\n  watch a quick tuturial !";
            // 
            // Videos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.Controls.Add(this.ChooseMuscleLabel);
            this.Controls.Add(this.Hamstrings);
            this.Controls.Add(this.LowerBack);
            this.Controls.Add(this.UpperBack);
            this.Controls.Add(this.Quads);
            this.Controls.Add(this.Biceps);
            this.Controls.Add(this.Shoulders);
            this.Controls.Add(this.Chest);
            this.Controls.Add(this.Tricep);
            this.Controls.Add(this.VideoPlayer);
            this.Name = "Videos";
            this.Size = new System.Drawing.Size(1160, 692);
            ((System.ComponentModel.ISupportInitialize)(this.VideoPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Tricep;
        private System.Windows.Forms.Button Chest;
        private System.Windows.Forms.Button Shoulders;
        private System.Windows.Forms.Button Biceps;
        private System.Windows.Forms.Button Hamstrings;
        private System.Windows.Forms.Button LowerBack;
        private System.Windows.Forms.Button UpperBack;
        private System.Windows.Forms.Button Quads;
        public AxWMPLib.AxWindowsMediaPlayer VideoPlayer;
        private System.Windows.Forms.Label ChooseMuscleLabel;
    }
}
