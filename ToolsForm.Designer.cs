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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolsForm));
            this.crystalDiskradioButton = new System.Windows.Forms.RadioButton();
            this.diagnosticogroupBox = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.saludBateriaradioButton = new System.Windows.Forms.RadioButton();
            this.saludhddradioButton = new System.Windows.Forms.RadioButton();
            this.ConfiguracionesgroupBox = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.AdminDiscosradioButton = new System.Windows.Forms.RadioButton();
            this.ControlPermisosradioButton = new System.Windows.Forms.RadioButton();
            this.AdminDispositivosradioButton = new System.Windows.Forms.RadioButton();
            this.NetFrameworkgroupBox = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.NetTresCincoradioButton = new System.Windows.Forms.RadioButton();
            this.NetCuatroradioButton = new System.Windows.Forms.RadioButton();
            this.NetCuatroCincoradioButton = new System.Windows.Forms.RadioButton();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.diagnosticogroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ConfiguracionesgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.NetFrameworkgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalDiskradioButton
            // 
            this.crystalDiskradioButton.AutoSize = true;
            this.crystalDiskradioButton.Location = new System.Drawing.Point(79, 25);
            this.crystalDiskradioButton.Name = "crystalDiskradioButton";
            this.crystalDiskradioButton.Size = new System.Drawing.Size(151, 19);
            this.crystalDiskradioButton.TabIndex = 0;
            this.crystalDiskradioButton.TabStop = true;
            this.crystalDiskradioButton.Text = "Salud HDD (CrystalDisk)";
            this.crystalDiskradioButton.UseVisualStyleBackColor = true;
            this.crystalDiskradioButton.CheckedChanged += new System.EventHandler(this.crystalDiskradioButton_CheckedChanged);
            // 
            // diagnosticogroupBox
            // 
            this.diagnosticogroupBox.Controls.Add(this.pictureBox1);
            this.diagnosticogroupBox.Controls.Add(this.saludBateriaradioButton);
            this.diagnosticogroupBox.Controls.Add(this.saludhddradioButton);
            this.diagnosticogroupBox.Controls.Add(this.crystalDiskradioButton);
            this.diagnosticogroupBox.Location = new System.Drawing.Point(34, 123);
            this.diagnosticogroupBox.Name = "diagnosticogroupBox";
            this.diagnosticogroupBox.Size = new System.Drawing.Size(314, 111);
            this.diagnosticogroupBox.TabIndex = 1;
            this.diagnosticogroupBox.TabStop = false;
            this.diagnosticogroupBox.Text = "Diagnóstico del Equipo";
            this.diagnosticogroupBox.Enter += new System.EventHandler(this.diagnosticogroupBox_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 57);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // saludBateriaradioButton
            // 
            this.saludBateriaradioButton.AutoSize = true;
            this.saludBateriaradioButton.Location = new System.Drawing.Point(79, 75);
            this.saludBateriaradioButton.Name = "saludBateriaradioButton";
            this.saludBateriaradioButton.Size = new System.Drawing.Size(167, 19);
            this.saludBateriaradioButton.TabIndex = 2;
            this.saludBateriaradioButton.TabStop = true;
            this.saludBateriaradioButton.Text = "Salud Bateria (Solo Laptop)";
            this.saludBateriaradioButton.UseVisualStyleBackColor = false;
            // 
            // saludhddradioButton
            // 
            this.saludhddradioButton.AutoSize = true;
            this.saludhddradioButton.Location = new System.Drawing.Point(79, 50);
            this.saludhddradioButton.Name = "saludhddradioButton";
            this.saludhddradioButton.Size = new System.Drawing.Size(82, 19);
            this.saludhddradioButton.TabIndex = 1;
            this.saludhddradioButton.TabStop = true;
            this.saludhddradioButton.Text = "Salud HDD";
            this.saludhddradioButton.UseVisualStyleBackColor = false;
            this.saludhddradioButton.CheckedChanged += new System.EventHandler(this.saludhddradioButton_CheckedChanged);
            // 
            // ConfiguracionesgroupBox
            // 
            this.ConfiguracionesgroupBox.Controls.Add(this.pictureBox2);
            this.ConfiguracionesgroupBox.Controls.Add(this.AdminDiscosradioButton);
            this.ConfiguracionesgroupBox.Controls.Add(this.ControlPermisosradioButton);
            this.ConfiguracionesgroupBox.Controls.Add(this.AdminDispositivosradioButton);
            this.ConfiguracionesgroupBox.Location = new System.Drawing.Point(34, 275);
            this.ConfiguracionesgroupBox.Name = "ConfiguracionesgroupBox";
            this.ConfiguracionesgroupBox.Size = new System.Drawing.Size(314, 113);
            this.ConfiguracionesgroupBox.TabIndex = 3;
            this.ConfiguracionesgroupBox.TabStop = false;
            this.ConfiguracionesgroupBox.Text = "Diagnóstico del Equipo";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 34);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 57);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // AdminDiscosradioButton
            // 
            this.AdminDiscosradioButton.AutoSize = true;
            this.AdminDiscosradioButton.Location = new System.Drawing.Point(79, 72);
            this.AdminDiscosradioButton.Name = "AdminDiscosradioButton";
            this.AdminDiscosradioButton.Size = new System.Drawing.Size(154, 19);
            this.AdminDiscosradioButton.TabIndex = 2;
            this.AdminDiscosradioButton.TabStop = true;
            this.AdminDiscosradioButton.Text = "Administrador de Discos";
            this.AdminDiscosradioButton.UseVisualStyleBackColor = false;
            this.AdminDiscosradioButton.CheckedChanged += new System.EventHandler(this.AdminDiscosradioButton_CheckedChanged);
            // 
            // ControlPermisosradioButton
            // 
            this.ControlPermisosradioButton.AutoSize = true;
            this.ControlPermisosradioButton.Location = new System.Drawing.Point(79, 47);
            this.ControlPermisosradioButton.Name = "ControlPermisosradioButton";
            this.ControlPermisosradioButton.Size = new System.Drawing.Size(132, 19);
            this.ControlPermisosradioButton.TabIndex = 1;
            this.ControlPermisosradioButton.TabStop = true;
            this.ControlPermisosradioButton.Text = "Control de Permisos";
            this.ControlPermisosradioButton.UseVisualStyleBackColor = false;
            this.ControlPermisosradioButton.CheckedChanged += new System.EventHandler(this.ControlPermisosradioButton_CheckedChanged);
            // 
            // AdminDispositivosradioButton
            // 
            this.AdminDispositivosradioButton.AutoSize = true;
            this.AdminDispositivosradioButton.Location = new System.Drawing.Point(79, 22);
            this.AdminDispositivosradioButton.Name = "AdminDispositivosradioButton";
            this.AdminDispositivosradioButton.Size = new System.Drawing.Size(183, 19);
            this.AdminDispositivosradioButton.TabIndex = 0;
            this.AdminDispositivosradioButton.TabStop = true;
            this.AdminDispositivosradioButton.Text = "Administrador de Dispositivos";
            this.AdminDispositivosradioButton.UseVisualStyleBackColor = true;
            this.AdminDispositivosradioButton.CheckedChanged += new System.EventHandler(this.AdminDispositivosradioButton_CheckedChanged);
            // 
            // NetFrameworkgroupBox
            // 
            this.NetFrameworkgroupBox.Controls.Add(this.pictureBox3);
            this.NetFrameworkgroupBox.Controls.Add(this.NetTresCincoradioButton);
            this.NetFrameworkgroupBox.Controls.Add(this.NetCuatroradioButton);
            this.NetFrameworkgroupBox.Controls.Add(this.NetCuatroCincoradioButton);
            this.NetFrameworkgroupBox.Location = new System.Drawing.Point(34, 427);
            this.NetFrameworkgroupBox.Name = "NetFrameworkgroupBox";
            this.NetFrameworkgroupBox.Size = new System.Drawing.Size(314, 113);
            this.NetFrameworkgroupBox.TabIndex = 4;
            this.NetFrameworkgroupBox.TabStop = false;
            this.NetFrameworkgroupBox.Text = "NetFramework";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(6, 34);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(51, 57);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // NetTresCincoradioButton
            // 
            this.NetTresCincoradioButton.AutoSize = true;
            this.NetTresCincoradioButton.Location = new System.Drawing.Point(79, 72);
            this.NetTresCincoradioButton.Name = "NetTresCincoradioButton";
            this.NetTresCincoradioButton.Size = new System.Drawing.Size(121, 19);
            this.NetTresCincoradioButton.TabIndex = 2;
            this.NetTresCincoradioButton.TabStop = true;
            this.NetTresCincoradioButton.Text = "NetFramework 3.5";
            this.NetTresCincoradioButton.UseVisualStyleBackColor = false;
            // 
            // NetCuatroradioButton
            // 
            this.NetCuatroradioButton.AutoSize = true;
            this.NetCuatroradioButton.Location = new System.Drawing.Point(79, 47);
            this.NetCuatroradioButton.Name = "NetCuatroradioButton";
            this.NetCuatroradioButton.Size = new System.Drawing.Size(121, 19);
            this.NetCuatroradioButton.TabIndex = 1;
            this.NetCuatroradioButton.TabStop = true;
            this.NetCuatroradioButton.Text = "NetFramework 4.0";
            this.NetCuatroradioButton.UseVisualStyleBackColor = false;
            // 
            // NetCuatroCincoradioButton
            // 
            this.NetCuatroCincoradioButton.AutoSize = true;
            this.NetCuatroCincoradioButton.Location = new System.Drawing.Point(79, 22);
            this.NetCuatroCincoradioButton.Name = "NetCuatroCincoradioButton";
            this.NetCuatroCincoradioButton.Size = new System.Drawing.Size(130, 19);
            this.NetCuatroCincoradioButton.TabIndex = 0;
            this.NetCuatroCincoradioButton.TabStop = true;
            this.NetCuatroCincoradioButton.Text = "NetFramework 4.5.2";
            this.NetCuatroCincoradioButton.UseVisualStyleBackColor = true;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(384, -10);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(26, 677);
            this.vScrollBar1.TabIndex = 5;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(123, -4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(146, 119);
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // ToolsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(125)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(408, 681);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.NetFrameworkgroupBox);
            this.Controls.Add(this.ConfiguracionesgroupBox);
            this.Controls.Add(this.diagnosticogroupBox);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ToolsForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Form1";
            this.diagnosticogroupBox.ResumeLayout(false);
            this.diagnosticogroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ConfiguracionesgroupBox.ResumeLayout(false);
            this.ConfiguracionesgroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.NetFrameworkgroupBox.ResumeLayout(false);
            this.NetFrameworkgroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RadioButton crystalDiskradioButton;
        private GroupBox diagnosticogroupBox;
        private RadioButton saludhddradioButton;
        private RadioButton saludBateriaradioButton;
        private GroupBox ConfiguracionesgroupBox;
        private RadioButton AdminDiscosradioButton;
        private RadioButton ControlPermisosradioButton;
        private RadioButton AdminDispositivosradioButton;
        private GroupBox NetFrameworkgroupBox;
        private RadioButton NetTresCincoradioButton;
        private RadioButton NetCuatroradioButton;
        private RadioButton NetCuatroCincoradioButton;
        private VScrollBar vScrollBar1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}