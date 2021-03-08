namespace ZiboManager
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxInformation = new System.Windows.Forms.GroupBox();
            this.labelPath = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.folderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reselectPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxPlugins = new System.Windows.Forms.GroupBox();
            this.labelAviatab = new System.Windows.Forms.Label();
            this.buttonAviatab = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxInformation.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.groupBoxPlugins.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxInformation
            // 
            this.groupBoxInformation.BackColor = System.Drawing.Color.White;
            this.groupBoxInformation.Controls.Add(this.labelVersion);
            this.groupBoxInformation.Controls.Add(this.labelPath);
            this.groupBoxInformation.Location = new System.Drawing.Point(12, 30);
            this.groupBoxInformation.Name = "groupBoxInformation";
            this.groupBoxInformation.Size = new System.Drawing.Size(288, 278);
            this.groupBoxInformation.TabIndex = 0;
            this.groupBoxInformation.TabStop = false;
            this.groupBoxInformation.Text = "Zibo information";
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Location = new System.Drawing.Point(6, 16);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(67, 13);
            this.labelPath.TabIndex = 0;
            this.labelPath.Text = "Aircraft path:";
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(6, 51);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(45, 13);
            this.labelVersion.TabIndex = 1;
            this.labelVersion.Text = "Version:";
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.folderToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(442, 24);
            this.menuStrip.TabIndex = 1;
            // 
            // folderToolStripMenuItem
            // 
            this.folderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reselectPathToolStripMenuItem});
            this.folderToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.folderToolStripMenuItem.Name = "folderToolStripMenuItem";
            this.folderToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.folderToolStripMenuItem.Text = "Folder";
            // 
            // reselectPathToolStripMenuItem
            // 
            this.reselectPathToolStripMenuItem.Name = "reselectPathToolStripMenuItem";
            this.reselectPathToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reselectPathToolStripMenuItem.Text = "Reselect path";
            this.reselectPathToolStripMenuItem.Click += new System.EventHandler(this.reselectPathToolStripMenuItem_Click);
            // 
            // groupBoxPlugins
            // 
            this.groupBoxPlugins.Controls.Add(this.button1);
            this.groupBoxPlugins.Controls.Add(this.label1);
            this.groupBoxPlugins.Controls.Add(this.buttonAviatab);
            this.groupBoxPlugins.Controls.Add(this.labelAviatab);
            this.groupBoxPlugins.Location = new System.Drawing.Point(306, 30);
            this.groupBoxPlugins.Name = "groupBoxPlugins";
            this.groupBoxPlugins.Size = new System.Drawing.Size(127, 100);
            this.groupBoxPlugins.TabIndex = 2;
            this.groupBoxPlugins.TabStop = false;
            this.groupBoxPlugins.Text = "Plugins";
            // 
            // labelAviatab
            // 
            this.labelAviatab.AutoSize = true;
            this.labelAviatab.Location = new System.Drawing.Point(6, 16);
            this.labelAviatab.Name = "labelAviatab";
            this.labelAviatab.Size = new System.Drawing.Size(50, 13);
            this.labelAviatab.TabIndex = 0;
            this.labelAviatab.Text = "AviaTab:";
            // 
            // buttonAviatab
            // 
            this.buttonAviatab.Location = new System.Drawing.Point(62, 11);
            this.buttonAviatab.Name = "buttonAviatab";
            this.buttonAviatab.Size = new System.Drawing.Size(58, 23);
            this.buttonAviatab.TabIndex = 1;
            this.buttonAviatab.Text = "Install";
            this.buttonAviatab.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(62, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Install";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Terrain \r\nRadar:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(442, 320);
            this.Controls.Add(this.groupBoxPlugins);
            this.Controls.Add(this.groupBoxInformation);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.groupBoxInformation.ResumeLayout(false);
            this.groupBoxInformation.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.groupBoxPlugins.ResumeLayout(false);
            this.groupBoxPlugins.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInformation;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem folderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reselectPathToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxPlugins;
        private System.Windows.Forms.Button buttonAviatab;
        private System.Windows.Forms.Label labelAviatab;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

