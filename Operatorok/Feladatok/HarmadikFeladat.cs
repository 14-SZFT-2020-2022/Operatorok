using System;
using System.Collections.Generic;
using Operatorok.Objektumok;

namespace Operatorok.Feladatok
{
    class HarmadikFeladat
    {
        static public void Megoldas(List<Operator> lista)
        {
            int modSzam = 0;

            foreach (Operator elem in lista)
            {
                if (elem.Muvelet == "mod")
                {
                    modSzam++;
                }
            }

            Console.WriteLine($"3. feladat: Kifejezések maradékos osztállyal: {modSzam}");
        }
    }
}
