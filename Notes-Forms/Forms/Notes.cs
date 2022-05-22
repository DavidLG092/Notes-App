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

namespace Notes_Forms
{
    public partial class Notes : Form
    {

        private static string path;
        private static DirectoryInfo dir;
        private static FileInfo[] info;

        public Notes()
        {
            InitializeComponent();
            path = System.Environment.CurrentDirectory.ToString();
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
                dir = new DirectoryInfo(folderDiag.SelectedPath);

                info = dir.GetFiles();

                txtDirectory.Text = folderDiag.SelectedPath;
                
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
    }
}
