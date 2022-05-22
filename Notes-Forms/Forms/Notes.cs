using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Notes_Forms.Forms;

namespace Notes_Forms
{
    public partial class Notes : Form
    {
        private static CreateFile form;

        private static string mainPath;
        private static string currentPath;
        private static string date;
        private static DirectoryInfo dir;
        private static FileInfo[] info;

        public Notes()
        {
            InitializeComponent();

            mainPath = System.Environment.CurrentDirectory.ToString() + @"\Notes";
            date = System.DateTime.Now.ToString("d").Replace("/", "_");
            currentPath = mainPath + @"\" + date;

            if (!Directory.Exists(mainPath))
            {
                Directory.CreateDirectory(mainPath);
                Directory.CreateDirectory(currentPath);
            }
            else
            {
                if (!Directory.Exists(currentPath))
                {
                    Directory.CreateDirectory(currentPath);
                }
            }

            txtDirectory.Text = currentPath;
        }

        private void Notes_Load(object sender, EventArgs e)
        {

        }

        private void lblFiles_Click(object sender, EventArgs e)
        {

        }

        private void txtFiles_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void lblContent_Click(object sender, EventArgs e)
        {

        }

        private void txtContent_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (folderDiag.ShowDialog() == DialogResult.OK)
            {
                currentPath = folderDiag.SelectedPath;
                txtDirectory.Text = currentPath;

                dir = new DirectoryInfo(currentPath);
                info = dir.GetFiles();
                
                foreach (var item in info)
                {
                    txtFiles.Text += item.Name;
                    txtFiles.Text += Environment.NewLine;
                }
            }
        }

        private void txtDirectory_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            form = new CreateFile(currentPath);
            form.Show();
        }
    }
}
