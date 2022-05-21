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
        public void Create(string nm)
        {
            if (!File.Exists(nm))
            {
                File.Create(nm);
                Console.WriteLine("Sucesso! O arquivo {0} foi criado!", nm);
            }
            else
            {
                Console.WriteLine("Um arquivo com esse nome já existe no diretório indicado!");
            }
        }

        public void Delete(string nm)
        {
            if (File.Exists(nm))
            {
                Console.WriteLine("Você deseja apagar o arquivo {0}.", nm);
                Console.Write("Tem certeza? (Y/N)\n> ");
                var conf = Console.ReadLine();

                if ((conf.ToLower().Equals("y")))
                {
                    File.Delete(nm);
                    Console.WriteLine("Sucesso! O arquivo {1} foi removido!", nm);
                }
                else
                {
                    Console.WriteLine("Nenhum arquivo foi apagado!");
                }
            }
            else
            {
                Console.WriteLine("Não existe nenhum arquivo {0} localizado neste diretório", nm);
            }
        }

        public void Modify(string nm)
        {
            if (File.Exists(nm))
            {
                
            }
            else
            {
                Console.WriteLine("Não existe nenhum arquivo {0} localizado neste diretório", nm);
            }
        }
    }
}
