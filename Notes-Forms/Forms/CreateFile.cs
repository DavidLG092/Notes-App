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

namespace Notes_Forms.Forms
{
    public partial class CreateFile : Form
    {
        private static string path;

        public CreateFile(string p)
        {
            path = p;
            InitializeComponent();
        }

        private void CreateFile_Load(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string fullName = path + @"\" + txtFileName.Text + ".txt";

            if (!File.Exists(fullName))
            {
                FileStream fs = File.Create(fullName);
                MessageBox.Show("Sucesso! Arquivo \"" + txtFileName.Text + "\" foi criado!", "Criação de arquivo");
                fs.Close();
                Close();
            }
            else
            {
                MessageBox.Show("Não foi possível criar o arquivo desejado, porque um arquivo de mesmo nome já existe!", "Criação de arquivo");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
