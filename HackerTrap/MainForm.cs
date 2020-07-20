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
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Tray.Visible = false;
        }
    }
}
