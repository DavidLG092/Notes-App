using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Notes
{
    internal class Folder
    {
        private static string mainPath;
        private static string currentPath;
        private static string date;

        public Folder()
        {
            mainPath = System.Environment.CurrentDirectory + @"\Notes\";
            date = System.DateTime.Today.ToString("d").Replace("/", "_");
        }

        public void Create(string nm = null)
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
                Console.WriteLine("Sucesso! Diretório {0} foi criado!", currentPath);
            }
            else
            {
                Console.WriteLine("Não foi possível criar o diretório desejado, diretório {0} já existe.", currentPath);
            }
        }

        public void Delete(string nm = null)
        {
            if (nm == null || nm == "")
            {
                Directory.Delete(currentPath, true);
                currentPath = mainPath;
                Console.WriteLine("Sucesso! Diretório {0} foi deletado.", currentPath);
            }
            else
            {
                if (Directory.Exists(mainPath + nm))
                {
                    Directory.Delete(mainPath + nm);
                    Console.WriteLine("Sucesso! Diretório {0} foi deletado.", mainPath + nm);
                }
                else
                {
                    Console.WriteLine("Diretório {0} não existe, não foi possível deletá-lo.", mainPath + nm);
                }
            }
        }
    }
}
