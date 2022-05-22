using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Notes
{
    internal class OldNote
    {
        public void Create(string nm)
        {
            if (!File.Exists(nm))
            {
                File.Create(nm);
                MessageBox.Show("Sucesso! O arquivo \"" + nm + "\" foi criado!", "Apagar arquivo");
                //Console.WriteLine("Sucesso! O arquivo {0} foi criado!", nm);
            }
            else
            {
                MessageBox.Show("Um arquivo com esse nome já existe no diretório indicado!");
                //Console.WriteLine("Um arquivo com esse nome já existe no diretório indicado!");
            }
        }

        public void Delete(string nm)
        {
            if (File.Exists(nm))
            {
                MessageBoxButtons btn = MessageBoxButtons.YesNo;
                DialogResult conf = MessageBox.Show("Você deseja apagar o arquivo " + nm + ".\nTem certeza?", "Apagar arquivo", btn);

                /*Console.WriteLine("Você deseja apagar o arquivo {0}.", nm);
                Console.Write("Tem certeza? (Y/N)\n> ");
                var conf = Console.ReadLine();*/

                if (conf == DialogResult.Yes)
                {
                    File.Delete(nm);
                    MessageBox.Show("Sucesso! O arquivo " + nm + " foi removido!", "Apagar arquivo");
                    //Console.WriteLine("Sucesso! O arquivo {1} foi removido!", nm);
                }
                else
                {
                    MessageBox.Show("Nenhum arquivo foi apagado!", "Apagar arquivo");
                    //Console.WriteLine("Nenhum arquivo foi apagado!");
                }
            }
            else
            {
                MessageBox.Show("Não existe nenhum arquivo \"" + nm + "\" localizado neste diretório", "Apagar arquivo");
                //Console.WriteLine("Não existe nenhum arquivo {0} localizado neste diretório", nm);
            }
        }

        public void Modify(string nm)
        {
            string fileText;
            TextBox tb = new TextBox();

            if (File.Exists(nm))
            {
                fileText = File.ReadAllText(nm);
                tb.Text = fileText;
                tb.Show();
                Console.ReadLine();

                /*
                while (!(Console.ReadKey().Key == ConsoleKey.Enter))
                {
                    switch (Console.ReadKey().Key)
                    {
                        case ConsoleKey.UpArrow:
                            try
                            {
                                Console.CursorTop -= 1;
                            }
                            catch (Exception ex)
                            {
                                Console.CursorTop = Console.CursorTop;
                            }
                            break;
                        case ConsoleKey.RightArrow:
                            try
                            {
                                Console.CursorLeft -= 1;
                            }
                            catch (Exception ex)
                            {
                                Console.CursorLeft = Console.CursorLeft;
                            }
                            break;
                        case ConsoleKey.DownArrow:
                            try
                            {
                                Console.CursorTop += 1;
                            }
                            catch (Exception ex)
                            {
                                Console.CursorTop = Console.CursorTop;
                            }
                            break;
                        case ConsoleKey.LeftArrow:
                            try
                            {
                                Console.CursorLeft += 1;
                            }
                            catch (Exception ex)
                            {
                                Console.CursorLeft = Console.CursorLeft;
                            }
                                break;
                        case ConsoleKey.Backspace:
                            break;
                    }
                }*/
            }
            else
            {
                MessageBox.Show("Não existe nenhum arquivo \"" + nm + "\" localizado neste diretório", "Apagar arquivo");
                //Console.WriteLine("Não existe nenhum arquivo {0} localizado neste diretório", nm);
            }
        }
    }
}
