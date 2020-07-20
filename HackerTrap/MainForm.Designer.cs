namespace HackerTrap
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Tray = new System.Windows.Forms.NotifyIcon(this.components);
            this.trackedFiles = new System.Windows.Forms.ListBox();
            this.butAddFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.butAddDir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Tray
            // 
            this.Tray.Icon = ((System.Drawing.Icon)(resources.GetObject("Tray.Icon")));
            this.Tray.Text = "Всё под контролем";
            this.Tray.Visible = true;
            // 
            // trackedFiles
            // 
            this.trackedFiles.FormattingEnabled = true;
            this.trackedFiles.ItemHeight = 20;
            this.trackedFiles.Location = new System.Drawing.Point(12, 35);
            this.trackedFiles.Name = "trackedFiles";
            this.trackedFiles.Size = new System.Drawing.Size(316, 404);
            this.trackedFiles.TabIndex = 0;
            this.trackedFiles.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.trackedFiles_KeyPress);
            // 
            // butAddFile
            // 
            this.butAddFile.Location = new System.Drawing.Point(12, 445);
            this.butAddFile.Name = "butAddFile";
            this.butAddFile.Size = new System.Drawing.Size(155, 33);
            this.butAddFile.TabIndex = 1;
            this.butAddFile.Text = "Добавить файл";
            this.butAddFile.UseVisualStyleBackColor = true;
            this.butAddFile.Click += new System.EventHandler(this.butAddFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Отслеживаемые файлы и директории:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // butAddDir
            // 
            this.butAddDir.Location = new System.Drawing.Point(173, 445);
            this.butAddDir.Name = "butAddDir";
            this.butAddDir.Size = new System.Drawing.Size(155, 33);
            this.butAddDir.TabIndex = 1;
            this.butAddDir.Text = "Добавить папку";
            this.butAddDir.UseVisualStyleBackColor = true;
            this.butAddDir.Click += new System.EventHandler(this.butAddDir_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 490);
            this.Controls.Add(this.butAddDir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butAddFile);
            this.Controls.Add(this.trackedFiles);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon Tray;
        private System.Windows.Forms.ListBox trackedFiles;
        private System.Windows.Forms.Button butAddFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button butAddDir;
    }
}

