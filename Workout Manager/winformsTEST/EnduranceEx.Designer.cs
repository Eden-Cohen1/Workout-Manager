
namespace winformsTEST
{
    partial class EnduranceEx
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
            this.PaceTextBox = new System.Windows.Forms.TextBox();
            this.distanceTextBox = new System.Windows.Forms.TextBox();
            this.Distance = new System.Windows.Forms.Label();
            this.avragePace = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PaceTextBox
            // 
            this.PaceTextBox.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.PaceTextBox.Location = new System.Drawing.Point(305, 98);
            this.PaceTextBox.Name = "PaceTextBox";
            this.PaceTextBox.Size = new System.Drawing.Size(101, 36);
            this.PaceTextBox.TabIndex = 42;
            this.PaceTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // distanceTextBox
            // 
            this.distanceTextBox.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.distanceTextBox.Location = new System.Drawing.Point(305, 35);
            this.distanceTextBox.Name = "distanceTextBox";
            this.distanceTextBox.Size = new System.Drawing.Size(102, 36);
            this.distanceTextBox.TabIndex = 40;
            // 
            // Distance
            // 
            this.Distance.AutoSize = true;
            this.Distance.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Distance.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Distance.Location = new System.Drawing.Point(24, 38);
            this.Distance.Name = "Distance";
            this.Distance.Size = new System.Drawing.Size(102, 33);
            this.Distance.TabIndex = 39;
            this.Distance.Text = "Distance:";
            this.Distance.Click += new System.EventHandler(this.Distance_Click);
            // 
            // avragePace
            // 
            this.avragePace.AutoSize = true;
            this.avragePace.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avragePace.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.avragePace.Location = new System.Drawing.Point(24, 97);
            this.avragePace.Name = "avragePace";
            this.avragePace.Size = new System.Drawing.Size(275, 33);
            this.avragePace.TabIndex = 38;
            this.avragePace.Text = "Average Pace (in minutes):";
            // 
            // EnduranceEx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(56)))));
            this.Controls.Add(this.PaceTextBox);
            this.Controls.Add(this.distanceTextBox);
            this.Controls.Add(this.Distance);
            this.Controls.Add(this.avragePace);
            this.Name = "EnduranceEx";
            this.Size = new System.Drawing.Size(456, 365);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Distance;
        private System.Windows.Forms.Label avragePace;
        public System.Windows.Forms.TextBox distanceTextBox;
        public System.Windows.Forms.TextBox PaceTextBox;
    }
}
