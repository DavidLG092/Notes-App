using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Notes
{
    internal class OldFolder
    {
        // Variáveis de diretório
        private static string mainPath;
        private static string currentPath;
        private static string date;

        // Variáveis de arquivo
        private OldNote n;
        private static string fileName;

        public OldFolder()
        {
            mainPath = System.Environment.CurrentDirectory + @"\Notes\";
            currentPath = mainPath;
            date = System.DateTime.Today.ToString("d").Replace("/", "_");
        }

        // Métodos de diretório

        public void CreateDirectory(string nm = null)
        {
            if (nm == null || nm == "")
            {
                currentPath = mainPath + date;
            }
            else
            {
                currentPath = mainPath + nm;
            }

            if (!Directory.Exists(currentPath))
            {
                Directory.CreateDirectory(currentPath);
                MessageBox.Show("Sucesso! Diretório \"" + currentPath + "\" foi criado!", "Criar diretório");
                //Console.WriteLine("Sucesso! Diretório {0} foi criado!", currentPath);
            }
            else
            {
                MessageBox.Show("Não foi possível criar o diretório desejado, diretório \"" + currentPath + "\" já existe.", "Criar diretório");
                //Console.WriteLine("Não foi possível criar o diretório desejado, diretório {0} já existe.", currentPath);
            }
        }

        public void Deleteirectory(string nm = null)
        {
            if (nm == null || nm == "")
            {
                Directory.Delete(currentPath, true);
                currentPath = mainPath;
                MessageBox.Show("Sucesso! Diretório \"" + currentPath + "\" foi removido.", "Apagar diretório");
                //Console.WriteLine("Sucesso! Diretório {0} foi deletado.", currentPath);
            }
            else
            {
                if (Directory.Exists(mainPath + nm))
                {
                    Directory.Delete(mainPath + nm);
                    MessageBox.Show("Sucesso! Diretório \"" + mainPath + nm + "\" foi removido.", "Apagar diretório");
                    //Console.WriteLine("Sucesso! Diretório {0} foi deletado.", mainPath + nm);
                }
                else
                {
                    MessageBox.Show("Diretório \"" + mainPath + nm + "\" não existe, não foi possível removê-lo.", "Apagar diretório");
                    //Console.WriteLine("Diretório {0} não existe, não foi possível deletá-lo.", mainPath + nm);
                }
            }
        }

        public void MoveToDirectory(string nm)
        {
            currentPath = mainPath + nm;

            if (!Directory.Exists(currentPath))
            {
                //Console.WriteLine("O diretório informado não existe. Garanta que o nome tenha sido digitado corretamente.");
            }
            else
            {
                ListDirectory(currentPath);
            }
        }

        private void ListDirectory(string nm)
        {
            DirectoryInfo dir = new DirectoryInfo(nm);
            int i = 1;

            foreach (FileInfo file in dir.GetFiles())
            {
                Console.WriteLine("{0} - {1}", i, file.Name.Remove(file.Name.ToString().IndexOf("."), 4));
                i++;
            }
        }

        // Métodos de arquivos

        public void CreateFile(string nm)
        {
            n = new Note();

            if (nm == null || nm == "")
            {
                fileName = currentPath + date;
            }
            else
            {
                fileName = currentPath + nm;
            }

            n.Create(fileName);
        }

        public void DeleteFile(string nm)
        {
            n = new Note();

            if (nm == null || nm == "")
            {
                fileName = currentPath + date;
            }
            else
            {
                fileName = currentPath + nm;
            }

            n.Delete(fileName);
        }

        public void ModifyFile(string nm)
        {
            n = new Note();

            if (nm == null || nm == "")
            {
                fileName = currentPath + date;
            }
            else
            {
                fileName = currentPath + nm;
            }

            n.Modify(fileName);
        }

    }
}
