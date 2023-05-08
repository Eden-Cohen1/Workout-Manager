
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
            this.PaceTextBox.Location = new System.Drawing.Point(610, 188);
            this.PaceTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.PaceTextBox.Name = "PaceTextBox";
            this.PaceTextBox.Size = new System.Drawing.Size(198, 64);
            this.PaceTextBox.TabIndex = 42;
            this.PaceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PaceTextBox_KeyPress);
            // 
            // distanceTextBox
            // 
            this.distanceTextBox.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.distanceTextBox.Location = new System.Drawing.Point(610, 67);
            this.distanceTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.distanceTextBox.Name = "distanceTextBox";
            this.distanceTextBox.Size = new System.Drawing.Size(200, 64);
            this.distanceTextBox.TabIndex = 40;
            this.distanceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.distanceTextBox_KeyPress);
            // 
            // Distance
            // 
            this.Distance.AutoSize = true;
            this.Distance.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Distance.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Distance.Location = new System.Drawing.Point(48, 73);
            this.Distance.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Distance.Name = "Distance";
            this.Distance.Size = new System.Drawing.Size(201, 68);
            this.Distance.TabIndex = 39;
            this.Distance.Text = "Distance:";
            // 
            // avragePace
            // 
            this.avragePace.AutoSize = true;
            this.avragePace.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avragePace.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.avragePace.Location = new System.Drawing.Point(48, 187);
            this.avragePace.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.avragePace.Name = "avragePace";
            this.avragePace.Size = new System.Drawing.Size(542, 68);
            this.avragePace.TabIndex = 38;
            this.avragePace.Text = "Average Pace (in minutes):";
            // 
            // EnduranceEx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.Controls.Add(this.PaceTextBox);
            this.Controls.Add(this.distanceTextBox);
            this.Controls.Add(this.Distance);
            this.Controls.Add(this.avragePace);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "EnduranceEx";
            this.Size = new System.Drawing.Size(912, 702);
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
