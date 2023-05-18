
namespace winformsTEST.Forms
{
    partial class AboutUs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutUs));
            this.myWlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // myWlabel
            // 
            this.myWlabel.AutoSize = true;
            this.myWlabel.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold);
            this.myWlabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.myWlabel.Location = new System.Drawing.Point(16, 19);
            this.myWlabel.Name = "myWlabel";
            this.myWlabel.Size = new System.Drawing.Size(1036, 693);
            this.myWlabel.TabIndex = 24;
            this.myWlabel.Text = resources.GetString("myWlabel.Text");
            // 
            // AboutUs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.Controls.Add(this.myWlabel);
            this.Name = "AboutUs";
            this.Size = new System.Drawing.Size(1074, 692);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label myWlabel;
    }
}
