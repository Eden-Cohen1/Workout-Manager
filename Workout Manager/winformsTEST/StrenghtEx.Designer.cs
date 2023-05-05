
namespace winformsTEST
{
    partial class StrenghtEx
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
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.repTextBox = new System.Windows.Forms.TextBox();
            this.Reps = new System.Windows.Forms.Label();
            this.Sets = new System.Windows.Forms.Label();
            this.weight = new System.Windows.Forms.Label();
            this.setsTextBox = new System.Windows.Forms.TextBox();
            this.calTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // weightTextBox
            // 
            this.weightTextBox.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.weightTextBox.Location = new System.Drawing.Point(238, 147);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(173, 36);
            this.weightTextBox.TabIndex = 33;
            // 
            // repTextBox
            // 
            this.repTextBox.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.repTextBox.Location = new System.Drawing.Point(235, 33);
            this.repTextBox.Name = "repTextBox";
            this.repTextBox.Size = new System.Drawing.Size(173, 36);
            this.repTextBox.TabIndex = 32;
            // 
            // Reps
            // 
            this.Reps.AutoSize = true;
            this.Reps.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reps.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Reps.Location = new System.Drawing.Point(25, 36);
            this.Reps.Name = "Reps";
            this.Reps.Size = new System.Drawing.Size(127, 33);
            this.Reps.TabIndex = 30;
            this.Reps.Text = "Repetitions:";
            // 
            // Sets
            // 
            this.Sets.AutoSize = true;
            this.Sets.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sets.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Sets.Location = new System.Drawing.Point(25, 95);
            this.Sets.Name = "Sets";
            this.Sets.Size = new System.Drawing.Size(60, 33);
            this.Sets.TabIndex = 29;
            this.Sets.Text = "Sets:";
            // 
            // weight
            // 
            this.weight.AutoSize = true;
            this.weight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.weight.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weight.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.weight.Location = new System.Drawing.Point(28, 146);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(87, 33);
            this.weight.TabIndex = 28;
            this.weight.Text = "Weight:";
            this.weight.Click += new System.EventHandler(this.label2_Click);
            // 
            // setsTextBox
            // 
            this.setsTextBox.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.setsTextBox.Location = new System.Drawing.Point(235, 92);
            this.setsTextBox.Name = "setsTextBox";
            this.setsTextBox.Size = new System.Drawing.Size(173, 36);
            this.setsTextBox.TabIndex = 34;
            // 
            // calTextBox
            // 
            this.calTextBox.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.calTextBox.Location = new System.Drawing.Point(238, 210);
            this.calTextBox.Name = "calTextBox";
            this.calTextBox.Size = new System.Drawing.Size(173, 36);
            this.calTextBox.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.label1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(28, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 33);
            this.label1.TabIndex = 36;
            this.label1.Text = "Calories Per Rep:";
            // 
            // StrenghtEx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calTextBox);
            this.Controls.Add(this.setsTextBox);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(this.repTextBox);
            this.Controls.Add(this.Reps);
            this.Controls.Add(this.Sets);
            this.Controls.Add(this.weight);
            this.Name = "StrenghtEx";
            this.Size = new System.Drawing.Size(456, 365);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Reps;
        private System.Windows.Forms.Label Sets;
        private System.Windows.Forms.Label weight;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox repTextBox;
        public System.Windows.Forms.TextBox setsTextBox;
        public System.Windows.Forms.TextBox weightTextBox;
        public System.Windows.Forms.TextBox calTextBox;
    }
}
