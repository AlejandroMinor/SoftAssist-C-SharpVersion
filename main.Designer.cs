namespace SoftAssist
{
    partial class main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.x64button = new System.Windows.Forms.Button();
            this.centroMainForm = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(251)))));
            this.panel1.Controls.Add(this.x64button);
            this.panel1.Location = new System.Drawing.Point(0, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 456);
            this.panel1.TabIndex = 0;
            // 
            // x64button
            // 
            this.x64button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.x64button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(251)))));
            this.x64button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(251)))));
            this.x64button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.x64button.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.x64button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(174)))));
            this.x64button.Image = ((System.Drawing.Image)(resources.GetObject("x64button.Image")));
            this.x64button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.x64button.Location = new System.Drawing.Point(32, 17);
            this.x64button.Name = "x64button";
            this.x64button.Size = new System.Drawing.Size(118, 37);
            this.x64button.TabIndex = 0;
            this.x64button.Text = "x64";
            this.x64button.UseVisualStyleBackColor = true;
            this.x64button.Click += new System.EventHandler(this.x64button_Click_1);
            // 
            // centroMainForm
            // 
            this.centroMainForm.Location = new System.Drawing.Point(171, 12);
            this.centroMainForm.Name = "centroMainForm";
            this.centroMainForm.Size = new System.Drawing.Size(617, 380);
            this.centroMainForm.TabIndex = 1;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.centroMainForm);
            this.Name = "main";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button x64button;
        private Panel centroMainForm;
    }
}