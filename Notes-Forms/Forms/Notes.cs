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

        private static string file;

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

            UpdateDirInfo();
        }

        private void UpdateDirInfo()
        {
            txtDirectory.Text = currentPath;
            txtFiles.Text = "";

            dir = new DirectoryInfo(currentPath);
            info = dir.GetFiles();

            foreach (var item in info)
            {
                txtFiles.Text += item.Name;
                txtFiles.Text += Environment.NewLine;
            }
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
            try
            {
                File.Delete(file);
                file = "";
                txtFile.Text = "";
                txtContent.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo de errado occorreu.\nTenha certeza de que um novo arquivo foi selecionado.", "Apagar arquivo");
            }

            UpdateDirInfo();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                File.WriteAllText(file, txtContent.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo de errado occorreu.\nTenha certeza de que um novo arquivo foi selecionado.", "Editar arquivo");
            }
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

                UpdateDirInfo();
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string content = "";

            file = currentPath + @"\" + txtFile.Text + ".txt";

            if (File.Exists(file))
            {
                try
                {
                    content = File.ReadAllText(file);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Algo de errado ocorreu. Tente novamente mais tarde.", "Edição de arquivo");
                }

                txtContent.Text = content;
            }
            else
            {
                MessageBox.Show("Não foi possível editar o arquivo, pois o arquivo especificado não existe!", "Edição de arquivo");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateDirInfo();
        }
    }
}
