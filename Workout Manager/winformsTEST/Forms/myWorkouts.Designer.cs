
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
            this.nameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.durationCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.typeCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descripCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ViewWorkout = new System.Windows.Forms.Button();
            this.deleteBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // myWlabel
            // 
            this.myWlabel.AutoSize = true;
            this.myWlabel.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myWlabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.myWlabel.Location = new System.Drawing.Point(136, 108);
            this.myWlabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.myWlabel.Name = "myWlabel";
            this.myWlabel.Size = new System.Drawing.Size(481, 94);
            this.myWlabel.TabIndex = 23;
            this.myWlabel.Text = "MY WORKOUTS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(150, 352);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 57);
            this.label1.TabIndex = 24;
            this.label1.Text = "Workout Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(564, 404);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 57);
            this.label2.TabIndex = 25;
            this.label2.Text = "Duration";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(1050, 383);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 57);
            this.label3.TabIndex = 26;
            this.label3.Text = "Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(1498, 383);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 57);
            this.label4.TabIndex = 27;
            this.label4.Text = "Description";
            // 
            // myWorkoutsList
            // 
            this.myWorkoutsList.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.myWorkoutsList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.myWorkoutsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameCol,
            this.durationCol,
            this.typeCol,
            this.descripCol});
            this.myWorkoutsList.Cursor = System.Windows.Forms.Cursors.Default;
            this.myWorkoutsList.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myWorkoutsList.ForeColor = System.Drawing.Color.White;
            this.myWorkoutsList.FullRowSelect = true;
            this.myWorkoutsList.HideSelection = false;
            this.myWorkoutsList.Location = new System.Drawing.Point(120, 238);
            this.myWorkoutsList.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.myWorkoutsList.Name = "myWorkoutsList";
            this.myWorkoutsList.Size = new System.Drawing.Size(1878, 841);
            this.myWorkoutsList.TabIndex = 28;
            this.myWorkoutsList.UseCompatibleStateImageBehavior = false;
            this.myWorkoutsList.View = System.Windows.Forms.View.Details;
            // 
            // nameCol
            // 
            this.nameCol.Text = "Workout Name";
            this.nameCol.Width = 230;
            // 
            // durationCol
            // 
            this.durationCol.Text = "Durtaion";
            this.durationCol.Width = 239;
            // 
            // typeCol
            // 
            this.typeCol.Text = "Type";
            this.typeCol.Width = 230;
            // 
            // descripCol
            // 
            this.descripCol.Text = "Description";
            this.descripCol.Width = 230;
            // 
            // ViewWorkout
            // 
            this.ViewWorkout.BackColor = System.Drawing.Color.RoyalBlue;
            this.ViewWorkout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ViewWorkout.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewWorkout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ViewWorkout.Location = new System.Drawing.Point(120, 1127);
            this.ViewWorkout.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ViewWorkout.Name = "ViewWorkout";
            this.ViewWorkout.Size = new System.Drawing.Size(294, 77);
            this.ViewWorkout.TabIndex = 29;
            this.ViewWorkout.Text = "View Workout";
            this.ViewWorkout.UseVisualStyleBackColor = false;
            this.ViewWorkout.Click += new System.EventHandler(this.ViewWorkout_Click);
            // 
            // deleteBTN
            // 
            this.deleteBTN.BackColor = System.Drawing.Color.RoyalBlue;
            this.deleteBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteBTN.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBTN.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.deleteBTN.Location = new System.Drawing.Point(438, 1127);
            this.deleteBTN.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.deleteBTN.Name = "deleteBTN";
            this.deleteBTN.Size = new System.Drawing.Size(294, 77);
            this.deleteBTN.TabIndex = 30;
            this.deleteBTN.Text = "Delete Workout";
            this.deleteBTN.UseVisualStyleBackColor = false;
            this.deleteBTN.Click += new System.EventHandler(this.deleteBTN_Click);
            // 
            // myWorkouts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.Controls.Add(this.deleteBTN);
            this.Controls.Add(this.ViewWorkout);
            this.Controls.Add(this.myWorkoutsList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.myWlabel);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "myWorkouts";
            this.Size = new System.Drawing.Size(2148, 1331);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader durationCol;
        public System.Windows.Forms.ColumnHeader nameCol;
        private System.Windows.Forms.ColumnHeader typeCol;
        private System.Windows.Forms.ColumnHeader descripCol;
        public System.Windows.Forms.Label myWlabel;
        public System.Windows.Forms.ListView myWorkoutsList;
        private System.Windows.Forms.Button ViewWorkout;
        private System.Windows.Forms.Button deleteBTN;
    }
}
