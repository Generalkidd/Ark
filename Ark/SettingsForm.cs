using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ark
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            setPaths();
        }

        private void setPaths()
        {
            h1path.Text = Properties.Settings.Default.H1EKPath;
            h2path.Text = Properties.Settings.Default.H2EKPath;
            h3path.Text = Properties.Settings.Default.H3EKPath;
            h3odstpath.Text = Properties.Settings.Default.H3ODSTEKPath;
            hrpath.Text = Properties.Settings.Default.HREKPath;
            h4path.Text = Properties.Settings.Default.H4EKPath;
            h2apath.Text = Properties.Settings.Default.H2AMPEKPath;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.H1EKPath = h1path.Text + "\\Guerilla.exe";
            Properties.Settings.Default.H2EKPath = h2path.Text + "\\Guerilla.exe";
            Properties.Settings.Default.H3EKPath = h3path.Text + "\\Guerilla.exe";
            Properties.Settings.Default.H3ODSTEKPath = h3odstpath.Text + "\\Guerilla.exe";
            Properties.Settings.Default.HREKPath = hrpath.Text;
            Properties.Settings.Default.H4EKPath = h4path.Text + "\\Foundation.exe";
            Properties.Settings.Default.H2AMPEKPath = h2apath.Text + "\\Foundation.exe";
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void h1browse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
                h1path.Text = fbd.SelectedPath;
        }

        private void h2browse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
                h2path.Text = fbd.SelectedPath;
        }

        private void h3browse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
                h3path.Text = fbd.SelectedPath;
        }

        private void h3odstbrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
                h3odstpath.Text = fbd.SelectedPath;
        }

        private void hrbrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
                hrpath.Text = fbd.SelectedPath;
        }

        private void h4browse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
                h4path.Text = fbd.SelectedPath;
        }

        private void h2abrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
                h2apath.Text = fbd.SelectedPath;
        }
    }
}
