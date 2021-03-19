using System;
using System.Collections.Generic;
using Operatorok.FileKezeles;
using Operatorok.Objektumok;

namespace Operatorok.Feladatok
{
    class Megoldas
    {
        static public void Megoldasok()
        {
            string eleres = @"C:\Users\Lenovo\source\repos\Operatorok\Operatorok\bin\Debug\kifejezesek.txt";
            FileBeolvas beolvas = new FileBeolvas(eleres);
            List<string[]> tombLista = beolvas.Feltolt(' ');
            List<Operator> lista = Operator.OperatorListaLetrehozasa(tombLista);

            MasodikFeladat.Megoldas(lista);
            HarmadikFeladat.Megoldas(lista);
            NegyedikFeladat.Megoldas(lista);
            OtodikFeladat.Megoldas(lista);
            HetedikFeladat.Megoldas();
            NyolcadikFeladat.Megoldas(lista);

            Console.ReadKey(true);
        }
    }
}
