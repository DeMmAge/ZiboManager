namespace ZiboManager
{
    partial class FormFolderSelection
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
            this.radioButtonAlreadyInstalled = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.labelPath = new System.Windows.Forms.Label();
            this.buttonSelectPath = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.labelDownloading = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radioButtonAlreadyInstalled
            // 
            this.radioButtonAlreadyInstalled.AutoSize = true;
            this.radioButtonAlreadyInstalled.Location = new System.Drawing.Point(12, 12);
            this.radioButtonAlreadyInstalled.Name = "radioButtonAlreadyInstalled";
            this.radioButtonAlreadyInstalled.Size = new System.Drawing.Size(157, 17);
            this.radioButtonAlreadyInstalled.TabIndex = 0;
            this.radioButtonAlreadyInstalled.TabStop = true;
            this.radioButtonAlreadyInstalled.Text = "I have Zibo already installed";
            this.radioButtonAlreadyInstalled.UseVisualStyleBackColor = true;
            this.radioButtonAlreadyInstalled.CheckedChanged += new System.EventHandler(this.radioButtonAlreadyInstalled_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Enabled = false;
            this.radioButton1.Location = new System.Drawing.Point(12, 29);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(251, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "I don\'t have Zibo installed yet (Not implemented)\r\n";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Location = new System.Drawing.Point(12, 87);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(69, 13);
            this.labelPath.TabIndex = 2;
            this.labelPath.Text = "Specify path:";
            // 
            // buttonSelectPath
            // 
            this.buttonSelectPath.Location = new System.Drawing.Point(12, 103);
            this.buttonSelectPath.Name = "buttonSelectPath";
            this.buttonSelectPath.Size = new System.Drawing.Size(246, 21);
            this.buttonSelectPath.TabIndex = 4;
            this.buttonSelectPath.Text = "Specify";
            this.buttonSelectPath.UseVisualStyleBackColor = true;
            this.buttonSelectPath.Click += new System.EventHandler(this.buttonSelectPath_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 58);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(246, 23);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 5;
            this.progressBar.Visible = false;
            // 
            // labelDownloading
            // 
            this.labelDownloading.AutoSize = true;
            this.labelDownloading.BackColor = System.Drawing.Color.Transparent;
            this.labelDownloading.Location = new System.Drawing.Point(96, 62);
            this.labelDownloading.Name = "labelDownloading";
            this.labelDownloading.Size = new System.Drawing.Size(78, 13);
            this.labelDownloading.TabIndex = 6;
            this.labelDownloading.Text = "Downloading...";
            this.labelDownloading.Visible = false;
            // 
            // FormFolderSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(270, 136);
            this.ControlBox = false;
            this.Controls.Add(this.labelDownloading);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.buttonSelectPath);
            this.Controls.Add(this.labelPath);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.radioButtonAlreadyInstalled);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormFolderSelection";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Please specify Zibo folder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonAlreadyInstalled;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.Button buttonSelectPath;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label labelDownloading;
    }
}