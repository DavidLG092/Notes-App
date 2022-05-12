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
        string path;
        string file;

        public void Show(string path)
        {
            this.path = path;
            file = File.ReadAllText(this.path);
            Console.WriteLine(file);
        }

        public void Write()
        {
            string text;

            if (!(file == null || file == ""))
            {
                Show(@"C:\Users\user\Desktop\test.txt");
                text = file + "\n";
                text += Convert.ToString(Console.ReadLine());
            }
            else
            {
                Console.Write("> ");
                text = Convert.ToString(Console.ReadLine());
            }

            if (text.Contains("  "))
            {
                text.Replace("  ", "\n");
            }

            File.WriteAllText(path, text);
        }
    }
}
