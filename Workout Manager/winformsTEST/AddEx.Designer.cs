
namespace winformsTEST
{
    partial class AddEx
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEx));
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.muscleTextBox = new System.Windows.Forms.TextBox();
            this.typeDropDown = new System.Windows.Forms.FlowLayoutPanel();
            this.dropDown = new System.Windows.Forms.Button();
            this.Stamina = new System.Windows.Forms.Button();
            this.Strenght = new System.Windows.Forms.Button();
            this.HIIT = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.changeByType = new System.Windows.Forms.Panel();
            this.doneAddingEx = new System.Windows.Forms.Button();
            this.typeDropDown.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.nameTextBox.Location = new System.Drawing.Point(244, 157);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(173, 36);
            this.nameTextBox.TabIndex = 21;
            // 
            // muscleTextBox
            // 
            this.muscleTextBox.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.muscleTextBox.Location = new System.Drawing.Point(244, 229);
            this.muscleTextBox.Name = "muscleTextBox";
            this.muscleTextBox.Size = new System.Drawing.Size(173, 36);
            this.muscleTextBox.TabIndex = 20;
            // 
            // typeDropDown
            // 
            this.typeDropDown.Controls.Add(this.dropDown);
            this.typeDropDown.Controls.Add(this.Stamina);
            this.typeDropDown.Controls.Add(this.Strenght);
            this.typeDropDown.Controls.Add(this.HIIT);
            this.typeDropDown.Location = new System.Drawing.Point(219, 312);
            this.typeDropDown.MaximumSize = new System.Drawing.Size(237, 146);
            this.typeDropDown.MinimumSize = new System.Drawing.Size(237, 33);
            this.typeDropDown.Name = "typeDropDown";
            this.typeDropDown.Size = new System.Drawing.Size(237, 35);
            this.typeDropDown.TabIndex = 19;
            // 
            // dropDown
            // 
            this.dropDown.BackColor = System.Drawing.SystemColors.Control;
            this.dropDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dropDown.BackgroundImage")));
            this.dropDown.Dock = System.Windows.Forms.DockStyle.Top;
            this.dropDown.FlatAppearance.BorderSize = 0;
            this.dropDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.dropDown.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropDown.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dropDown.Image = ((System.Drawing.Image)(resources.GetObject("dropDown.Image")));
            this.dropDown.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dropDown.Location = new System.Drawing.Point(3, 3);
            this.dropDown.Name = "dropDown";
            this.dropDown.Size = new System.Drawing.Size(230, 30);
            this.dropDown.TabIndex = 12;
            this.dropDown.Text = "ADD EXERCISE";
            this.dropDown.UseVisualStyleBackColor = false;
            this.dropDown.Click += new System.EventHandler(this.dropDown_Click);
            // 
            // Stamina
            // 
            this.Stamina.Dock = System.Windows.Forms.DockStyle.Top;
            this.Stamina.FlatAppearance.BorderSize = 0;
            this.Stamina.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.Stamina.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stamina.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Stamina.Location = new System.Drawing.Point(3, 39);
            this.Stamina.Name = "Stamina";
            this.Stamina.Size = new System.Drawing.Size(230, 30);
            this.Stamina.TabIndex = 13;
            this.Stamina.Text = "ENDURANCE";
            this.Stamina.UseVisualStyleBackColor = true;
            this.Stamina.Click += new System.EventHandler(this.Stamina_Click);
            // 
            // Strenght
            // 
            this.Strenght.Dock = System.Windows.Forms.DockStyle.Top;
            this.Strenght.FlatAppearance.BorderSize = 0;
            this.Strenght.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.Strenght.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Strenght.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Strenght.Location = new System.Drawing.Point(3, 75);
            this.Strenght.Name = "Strenght";
            this.Strenght.Size = new System.Drawing.Size(230, 30);
            this.Strenght.TabIndex = 14;
            this.Strenght.Text = "STRENGHT";
            this.Strenght.UseVisualStyleBackColor = true;
            this.Strenght.Click += new System.EventHandler(this.Strenght_Click);
            // 
            // HIIT
            // 
            this.HIIT.Dock = System.Windows.Forms.DockStyle.Top;
            this.HIIT.FlatAppearance.BorderSize = 0;
            this.HIIT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.HIIT.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HIIT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.HIIT.Location = new System.Drawing.Point(3, 111);
            this.HIIT.Name = "HIIT";
            this.HIIT.Size = new System.Drawing.Size(230, 34);
            this.HIIT.TabIndex = 15;
            this.HIIT.Text = "HIIT";
            this.HIIT.UseVisualStyleBackColor = true;
            this.HIIT.Click += new System.EventHandler(this.HIIT_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(51, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 33);
            this.label3.TabIndex = 18;
            this.label3.Text = "Muscle Group:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(51, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 33);
            this.label1.TabIndex = 17;
            this.label1.Text = "Exercise Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(51, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 33);
            this.label2.TabIndex = 16;
            this.label2.Text = "Exercise Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(55, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 47);
            this.label4.TabIndex = 22;
            this.label4.Text = "Add An Exercise";
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // changeByType
            // 
            this.changeByType.Location = new System.Drawing.Point(518, 107);
            this.changeByType.Name = "changeByType";
            this.changeByType.Size = new System.Drawing.Size(467, 399);
            this.changeByType.TabIndex = 23;
            this.changeByType.Paint += new System.Windows.Forms.PaintEventHandler(this.changeByType_Paint);
            // 
            // doneAddingEx
            // 
            this.doneAddingEx.BackColor = System.Drawing.Color.RoyalBlue;
            this.doneAddingEx.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.doneAddingEx.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doneAddingEx.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.doneAddingEx.Location = new System.Drawing.Point(31, 466);
            this.doneAddingEx.Name = "doneAddingEx";
            this.doneAddingEx.Size = new System.Drawing.Size(131, 40);
            this.doneAddingEx.TabIndex = 24;
            this.doneAddingEx.Text = "Done";
            this.doneAddingEx.UseVisualStyleBackColor = false;
            this.doneAddingEx.Click += new System.EventHandler(this.doneAddingEx_Click);
            // 
            // AddEx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(56)))));
            this.Controls.Add(this.doneAddingEx);
            this.Controls.Add(this.changeByType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.muscleTextBox);
            this.Controls.Add(this.typeDropDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "AddEx";
            this.Size = new System.Drawing.Size(1074, 692);
            this.typeDropDown.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox muscleTextBox;
        private System.Windows.Forms.FlowLayoutPanel typeDropDown;
        private System.Windows.Forms.Button dropDown;
        private System.Windows.Forms.Button Stamina;
        private System.Windows.Forms.Button Strenght;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel changeByType;
        private System.Windows.Forms.Button doneAddingEx;
        private System.Windows.Forms.Button HIIT;
    }
}
