namespace SoftAssist
{
    partial class ToolsForm
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
            this.crystalDiskradioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // crystalDiskradioButton
            // 
            this.crystalDiskradioButton.AutoSize = true;
            this.crystalDiskradioButton.Location = new System.Drawing.Point(21, 22);
            this.crystalDiskradioButton.Name = "crystalDiskradioButton";
            this.crystalDiskradioButton.Size = new System.Drawing.Size(181, 19);
            this.crystalDiskradioButton.TabIndex = 0;
            this.crystalDiskradioButton.TabStop = true;
            this.crystalDiskradioButton.Text = "Salud HDD (Crystal Diskradio)";
            this.crystalDiskradioButton.UseVisualStyleBackColor = true;
            this.crystalDiskradioButton.CheckedChanged += new System.EventHandler(this.crystalDiskradioButton_CheckedChanged);
            // 
            // ToolsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(125)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(397, 281);
            this.Controls.Add(this.crystalDiskradioButton);
            this.Name = "ToolsForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton crystalDiskradioButton;
    }
}