using MedicosLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace MedicosUI
{
    public partial class BackupForm : Form
    {
        private string BackupPath { get; set; }
        private string RestorePath { get; set; }
        public BackupForm()
        {
            InitializeComponent();
        }

        // select the path for saving backup
        private void backupBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                BackupPath = dialog.SelectedPath;
                backupPathText.Text = BackupPath;
            }
        }

        private void createBackupButton_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(BackupPath))
            {
                MessageBox.Show("Folder does not exist. Select again.");
                return;
            }

            else
            {
                BackupModel model = new BackupModel();

                try
                {
                    model.CreateBackup(BackupPath);
                    MessageBox.Show("Backup Created Successfully.");
                }

                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Something went wrong while creating backup.\nSelect another path and try again.");
                }
            }
        }

        private void restoreBrowse_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "D:\\";
                openFileDialog.Filter = "bak File (*.bak)|*.bak|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    RestorePath = openFileDialog.FileName;
                }
            }
            restorePathText.Text = RestorePath;
        }

        private void restoreBackupButton_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Are you sure you want to restore database?", "Restore Database", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.No)
            {
                return;
            }

            BackupModel model = new BackupModel();
            try
            {
                model.RestoreDatabase(RestorePath);
                MessageBox.Show("Backup Restored Successfully.");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Something went wrong while restoring backup.\nSelect another file and try again.");
            }

        }
    }
}
