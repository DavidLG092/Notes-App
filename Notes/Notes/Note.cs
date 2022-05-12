using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Notes
{
    internal class Note
    {
        public void Create(string nm, string pt)
        {
            var fullName = pt + @"\" + nm;

            if (!File.Exists(fullName))
            {
                File.Create(fullName);
                Console.WriteLine("Sucesso! O arquivo {0} foi criado no diretório \"{1}\"!", nm, pt);
            }
            else
            {
                Console.WriteLine("Um arquivo com esse nome já existe no diretório indicado!");
            }
        }

        public void Delete(string nm, string pt)
        {
            var fullName = pt + @"\" + nm;

            if (File.Exists(fullName))
            {
                Console.WriteLine("Você deseja apagar o arquivo {0}, localizado em \"{1}\".", nm, pt);
                Console.Write("Tem certeza? (Y/N)\n> ");
                var conf = Console.ReadLine();

                if ((conf.ToLower().Equals("y")))
                {
                    File.Delete(fullName);
                    Console.WriteLine("Sucesso! O arquivo {1} foi removido do diretório \"{1}\"!", nm, pt);
                }
                else
                {
                    Console.WriteLine("Nenhum arquivo foi apagado!");
                }
            }
            else
            {
                Console.WriteLine("Não existe nenhum arquivo {0} localizado em \"{1}\"...", nm, pt);
            }
        }

        public void Modify(string nm, string pt)
        {
            var fullName = pt + @"\" + nm;

            if (File.Exists(fullName))
            {
                
            }
            else
            {
                Console.WriteLine("Não existe nenhum arquivo {0} localizado em \"{1}\"...", nm, pt);
            }
        }
    }
}
