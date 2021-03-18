using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Operatorok.FileKezeles;

namespace Operatorok
{
    class Program
    {
        static void Main(string[] args)
        {
            string eleres = @"C:\Users\Lenovo\source\repos\Operatorok\Operatorok\bin\Debug\kifejezesek.txt";
            FileBeolvas beolvas = new FileBeolvas(eleres);


            Console.ReadKey(true);
        }
    }
}
