namespace SoftAssist
{
    partial class x64Form
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(x64Form));
            this.ChromeCheckBox = new System.Windows.Forms.CheckBox();
            this.ChromeImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ChromeImg)).BeginInit();
            this.SuspendLayout();
            // 
            // ChromeCheckBox
            // 
            this.ChromeCheckBox.AutoSize = true;
            this.ChromeCheckBox.Location = new System.Drawing.Point(19, 68);
            this.ChromeCheckBox.Name = "ChromeCheckBox";
            this.ChromeCheckBox.Size = new System.Drawing.Size(98, 19);
            this.ChromeCheckBox.TabIndex = 0;
            this.ChromeCheckBox.Text = "Chrome (x64)";
            this.ChromeCheckBox.UseVisualStyleBackColor = true;
            // 
            // ChromeImg
            // 
            this.ChromeImg.Image = ((System.Drawing.Image)(resources.GetObject("ChromeImg.Image")));
            this.ChromeImg.Location = new System.Drawing.Point(42, 12);
            this.ChromeImg.Name = "ChromeImg";
            this.ChromeImg.Size = new System.Drawing.Size(50, 50);
            this.ChromeImg.TabIndex = 1;
            this.ChromeImg.TabStop = false;
            // 
            // x64Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.ChromeImg);
            this.Controls.Add(this.ChromeCheckBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "x64Form";
            this.Text = "x64";
            ((System.ComponentModel.ISupportInitialize)(this.ChromeImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox ChromeCheckBox;
        private PictureBox ChromeImg;
    }
}