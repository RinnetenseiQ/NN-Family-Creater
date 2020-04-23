using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NN_Family_Creater
{
    public partial class PropertyForm : Form
    {
        public PropertyForm()
        {
            InitializeComponent();
            directoryPathTB.Text = Properties.Settings.Default.DirectoryPath = ConfigEditor.Config.Read("DirectoryPath").ToString(); 
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //using (var dialog = new System.Windows.Forms.FolderBrowserDialog())
            //{
            //    System.Windows.Forms.DialogResult result = dialog.ShowDialog();

            //}
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                this.directoryPathTB.Text = FBD.SelectedPath;
            }
        }

        private void ApplyBtn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.DirectoryPath = directoryPathTB.Text;
            ConfigEditor.Config.Write("DirectoryPath", Properties.Settings.Default.DirectoryPath);
        }
    }
}
