using System.Text;
using System.IO;

namespace Operatorok.FileKezeles
{
    class FilebaKiir
    {
        public string FileNev { get; set; }

        public FilebaKiir(string fileNev)
        {
            this.FileNev = fileNev;
        }

        public void Kiiras(string kiir)
        {
            using (StreamWriter sw = new StreamWriter(this.FileNev, false, Encoding.UTF8))
            {
                sw.Write(kiir);
            }
        } 
    }
}
