using System;
using System.Collections.Generic;
using Operatorok.Objektumok;
using Operatorok.FileKezeles;

namespace Operatorok.Feladatok
{
    class NyolcadikFeladat
    {
        static public void Megoldas(List<Operator> lista)
        {
            Console.WriteLine("8. feladat: eredmenyek.txt");

            string kiir = "";

            foreach (Operator elem in lista)
            {
                string feldolgoz = elem.ElsoOperandus + " " + elem.Muvelet + " " + elem.MasodikOperandus;
                kiir += $"{feldolgoz} = {HatodikFeladat.Kiertekel(feldolgoz)}\n";
            }

            string fileNev = "eredmenyek.txt";
            FilebaKiir kiiras = new FilebaKiir(fileNev);
            kiiras.Kiiras(kiir);
        }
    }
}
