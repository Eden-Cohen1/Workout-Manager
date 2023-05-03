
namespace winformsTEST
{
    partial class myWorkouts
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
            this.myWlabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.myWorkoutsList = new System.Windows.Forms.ListView();
            this.Duration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // myWlabel
            // 
            this.myWlabel.AutoSize = true;
            this.myWlabel.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myWlabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.myWlabel.Location = new System.Drawing.Point(48, 46);
            this.myWlabel.Name = "myWlabel";
            this.myWlabel.Size = new System.Drawing.Size(242, 47);
            this.myWlabel.TabIndex = 23;
            this.myWlabel.Text = "MY WORKOUTS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(51, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 28);
            this.label1.TabIndex = 24;
            this.label1.Text = "Workout Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(286, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 28);
            this.label2.TabIndex = 25;
            this.label2.Text = "Duration";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(526, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 28);
            this.label3.TabIndex = 26;
            this.label3.Text = "Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(756, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 28);
            this.label4.TabIndex = 27;
            this.label4.Text = "Description";
            // 
            // myWorkoutsList
            // 
            this.myWorkoutsList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(56)))));
            this.myWorkoutsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Duration,
            this.Name,
            this.Type,
            this.Description});
            this.myWorkoutsList.ForeColor = System.Drawing.SystemColors.Menu;
            this.myWorkoutsList.HideSelection = false;
            this.myWorkoutsList.Location = new System.Drawing.Point(56, 195);
            this.myWorkoutsList.Name = "myWorkoutsList";
            this.myWorkoutsList.Size = new System.Drawing.Size(941, 439);
            this.myWorkoutsList.TabIndex = 28;
            this.myWorkoutsList.UseCompatibleStateImageBehavior = false;
            this.myWorkoutsList.View = System.Windows.Forms.View.Details;
            // 
            // Duration
            // 
            this.Duration.DisplayIndex = 1;
            this.Duration.Text = "Durtaion";
            this.Duration.Width = 239;
            // 
            // Name
            // 
            this.Name.DisplayIndex = 0;
            this.Name.Text = "Workout Name";
            this.Name.Width = 230;
            // 
            // Type
            // 
            this.Type.Text = "Type";
            this.Type.Width = 230;
            // 
            // Description
            // 
            this.Description.Text = "Description";
            this.Description.Width = 230;
            // 
            // myWorkouts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(56)))));
            this.Controls.Add(this.myWorkoutsList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.myWlabel);
/*            this.Name = "myWorkouts";
*/            this.Size = new System.Drawing.Size(1074, 692);
            this.Load += new System.EventHandler(this.myWorkouts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader Duration;
        public System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader Description;
        public System.Windows.Forms.Label myWlabel;
        public System.Windows.Forms.ListView myWorkoutsList;
    }
}
