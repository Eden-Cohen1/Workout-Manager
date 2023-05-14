
namespace winformsTEST
{
    partial class WorkoutPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkoutPage));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ExerciseList = new System.Windows.Forms.ListView();
            this.nameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.muscleCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.setsCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.repsCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.weightCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.restCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.distanceCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.paseCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IntensityCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headline = new System.Windows.Forms.Label();
            this.deleteBTN = new System.Windows.Forms.Button();
            this.editBTN = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AddBTN = new System.Windows.Forms.Button();
            this.exerciseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exerciseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(895, 625);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Size = new System.Drawing.Size(150, 35);
            this.splitContainer1.TabIndex = 20;
            this.splitContainer1.Visible = false;
            // 
            // ExerciseList
            // 
            this.ExerciseList.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.ExerciseList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.ExerciseList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameCol,
            this.muscleCol,
            this.setsCol,
            this.repsCol,
            this.weightCol,
            this.restCol,
            this.distanceCol,
            this.paseCol,
            this.IntensityCol});
            this.ExerciseList.Cursor = System.Windows.Forms.Cursors.Default;
            this.ExerciseList.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExerciseList.ForeColor = System.Drawing.Color.White;
            this.ExerciseList.FullRowSelect = true;
            this.ExerciseList.GridLines = true;
            this.ExerciseList.HideSelection = false;
            this.ExerciseList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ExerciseList.LabelEdit = true;
            this.ExerciseList.Location = new System.Drawing.Point(0, 98);
            this.ExerciseList.Name = "ExerciseList";
            this.ExerciseList.ShowItemToolTips = true;
            this.ExerciseList.Size = new System.Drawing.Size(1215, 542);
            this.ExerciseList.TabIndex = 29;
            this.ExerciseList.UseCompatibleStateImageBehavior = false;
            this.ExerciseList.View = System.Windows.Forms.View.Details;
            // 
            // nameCol
            // 
            this.nameCol.Text = "Exercise";
            this.nameCol.Width = 169;
            // 
            // muscleCol
            // 
            this.muscleCol.Text = "Muscle";
            this.muscleCol.Width = 131;
            // 
            // setsCol
            // 
            this.setsCol.Text = "Sets";
            this.setsCol.Width = 124;
            // 
            // repsCol
            // 
            this.repsCol.Text = "Repetitions";
            this.repsCol.Width = 118;
            // 
            // weightCol
            // 
            this.weightCol.Text = "Weight (kg)";
            this.weightCol.Width = 131;
            // 
            // restCol
            // 
            this.restCol.Text = "Rest Time";
            this.restCol.Width = 124;
            // 
            // distanceCol
            // 
            this.distanceCol.Text = "Distance (km)";
            this.distanceCol.Width = 138;
            // 
            // paseCol
            // 
            this.paseCol.Text = "Pase (per km)";
            this.paseCol.Width = 142;
            // 
            // IntensityCol
            // 
            this.IntensityCol.Text = "Intensity";
            this.IntensityCol.Width = 134;
            // 
            // headline
            // 
            this.headline.AutoSize = true;
            this.headline.BackColor = System.Drawing.Color.Transparent;
            this.headline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.headline.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headline.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.headline.Location = new System.Drawing.Point(20, 17);
            this.headline.Name = "headline";
            this.headline.Size = new System.Drawing.Size(315, 47);
            this.headline.TabIndex = 30;
            this.headline.Text = "MY WORKOUT PLAN";
            this.headline.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // deleteBTN
            // 
            this.deleteBTN.BackColor = System.Drawing.Color.RoyalBlue;
            this.deleteBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteBTN.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBTN.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.deleteBTN.Location = new System.Drawing.Point(170, 663);
            this.deleteBTN.Name = "deleteBTN";
            this.deleteBTN.Size = new System.Drawing.Size(139, 40);
            this.deleteBTN.TabIndex = 31;
            this.deleteBTN.Text = "Delete Exercise";
            this.deleteBTN.UseVisualStyleBackColor = false;
            this.deleteBTN.Click += new System.EventHandler(this.deleteBTN_Click);
            // 
            // editBTN
            // 
            this.editBTN.BackColor = System.Drawing.Color.RoyalBlue;
            this.editBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.editBTN.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBTN.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.editBTN.Location = new System.Drawing.Point(324, 663);
            this.editBTN.Name = "editBTN";
            this.editBTN.Size = new System.Drawing.Size(139, 40);
            this.editBTN.TabIndex = 32;
            this.editBTN.Text = "Edit Exercise";
            this.editBTN.UseVisualStyleBackColor = false;
            this.editBTN.Click += new System.EventHandler(this.editBTN_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(341, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 64);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // AddBTN
            // 
            this.AddBTN.BackColor = System.Drawing.Color.RoyalBlue;
            this.AddBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddBTN.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBTN.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AddBTN.Location = new System.Drawing.Point(14, 663);
            this.AddBTN.Name = "AddBTN";
            this.AddBTN.Size = new System.Drawing.Size(139, 40);
            this.AddBTN.TabIndex = 34;
            this.AddBTN.Text = "Add Exercise";
            this.AddBTN.UseVisualStyleBackColor = false;
            this.AddBTN.Click += new System.EventHandler(this.Add_Ex_Click);
            // 
            // exerciseBindingSource
            // 
            this.exerciseBindingSource.DataSource = typeof(EXERCISE.Exercise);
            // 
            // WorkoutPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.Controls.Add(this.AddBTN);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.editBTN);
            this.Controls.Add(this.deleteBTN);
            this.Controls.Add(this.headline);
            this.Controls.Add(this.ExerciseList);
            this.Controls.Add(this.splitContainer1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(56)))));
            this.Name = "WorkoutPage";
            this.Size = new System.Drawing.Size(1199, 709);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exerciseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.BindingSource exerciseBindingSource;
        public System.Windows.Forms.ListView ExerciseList;
        public System.Windows.Forms.ColumnHeader nameCol;
        public System.Windows.Forms.ColumnHeader repsCol;
        public System.Windows.Forms.ColumnHeader setsCol;
        public System.Windows.Forms.ColumnHeader weightCol;
        public System.Windows.Forms.ColumnHeader muscleCol;
        public System.Windows.Forms.ColumnHeader restCol;
        public System.Windows.Forms.ColumnHeader distanceCol;
        public System.Windows.Forms.ColumnHeader paseCol;
        public System.Windows.Forms.ColumnHeader IntensityCol;
        private System.Windows.Forms.Label headline;
        private System.Windows.Forms.Button deleteBTN;
        private System.Windows.Forms.Button editBTN;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button AddBTN;
    }
}
