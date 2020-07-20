using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HackerTrap
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Главная форма приложения
        /// </summary>
        /// 
        public MainForm()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;

            Tray.Visible = true;
            Tray.ContextMenuStrip = new ContextMenuStrip();

            var settings = new ToolStripMenuItem("Параметры");
            settings.Click += (o, e) =>
            {
                Tray.Visible = false;
                this.WindowState = FormWindowState.Normal;
                this.ShowInTaskbar = true;
            };

            var exit = new ToolStripMenuItem("Выход");
            exit.Click += (o, e) =>
            {
                Tray.Visible = false;
                Application.Exit();
            };

            Tray.ContextMenuStrip.Items.Add(settings);
            Tray.ContextMenuStrip.Items.Add(exit);

            trackedFiles.HorizontalScrollbar = true;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Tray.Visible = false;
        }

        private void trackedFiles_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 46)
                trackedFiles.Items.Remove(trackedFiles.SelectedItem);
        }

        private void butAddFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                trackedFiles.Items.Add(openFileDialog1.FileName);
        }

        private void butAddDir_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                trackedFiles.Items.Add(folderBrowserDialog1.SelectedPath);
        }
    }
}
