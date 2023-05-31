
namespace winformsTEST.Forms
{
    partial class NotesPage
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
            this.headlineText = new System.Windows.Forms.TextBox();
            this.Shoulders = new System.Windows.Forms.Button();
            this.headlineLable = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // headlineText
            // 
            this.headlineText.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold);
            this.headlineText.Location = new System.Drawing.Point(289, 165);
            this.headlineText.Multiline = true;
            this.headlineText.Name = "headlineText";
            this.headlineText.Size = new System.Drawing.Size(619, 79);
            this.headlineText.TabIndex = 27;
            // 
            // Shoulders
            // 
            this.Shoulders.BackColor = System.Drawing.Color.RoyalBlue;
            this.Shoulders.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Shoulders.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Shoulders.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Shoulders.Location = new System.Drawing.Point(289, 264);
            this.Shoulders.Margin = new System.Windows.Forms.Padding(6);
            this.Shoulders.Name = "Shoulders";
            this.Shoulders.Size = new System.Drawing.Size(309, 81);
            this.Shoulders.TabIndex = 28;
            this.Shoulders.TabStop = false;
            this.Shoulders.Text = "Create Note";
            this.Shoulders.UseVisualStyleBackColor = false;
            this.Shoulders.Click += new System.EventHandler(this.Shoulders_Click);
            // 
            // headlineLable
            // 
            this.headlineLable.AutoSize = true;
            this.headlineLable.Font = new System.Drawing.Font("Segoe Print", 16.25F, System.Drawing.FontStyle.Bold);
            this.headlineLable.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.headlineLable.Location = new System.Drawing.Point(20, 165);
            this.headlineLable.Name = "headlineLable";
            this.headlineLable.Size = new System.Drawing.Size(266, 79);
            this.headlineLable.TabIndex = 29;
            this.headlineLable.Text = "Note Text:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(626, 264);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(282, 81);
            this.button1.TabIndex = 30;
            this.button1.TabStop = false;
            this.button1.Text = "Delete Note";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 16.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 79);
            this.label1.TabIndex = 31;
            this.label1.Text = "WORKOUT NOTES";
            // 
            // NotesPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.headlineLable);
            this.Controls.Add(this.Shoulders);
            this.Controls.Add(this.headlineText);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "NotesPage";
            this.Size = new System.Drawing.Size(2148, 1331);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox headlineText;
        private System.Windows.Forms.Button Shoulders;
        private System.Windows.Forms.Label headlineLable;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}
