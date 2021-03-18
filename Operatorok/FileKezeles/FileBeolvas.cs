using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Operatorok.FileKezeles
{
    class FileBeolvas
    {
        public string FileNev { get; set; }

        public FileBeolvas(string fileNev)
        {
            this.FileNev = fileNev;
        }

        public List<string[]> Feltolt(char delimiter)
        {
            List<string[]> lista = new List<string[]>();

            using (StreamReader sr = new StreamReader(this.FileNev, Encoding.UTF8))
            {
                while (!sr.EndOfStream)
                {
                    string sor = sr.ReadLine().Trim();
                    string[] tomb = sor.Split(delimiter);
                    lista.Add(tomb);
                }
            }

            return lista;
        }
    }
}
