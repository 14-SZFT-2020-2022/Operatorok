using System;
using System.Collections.Generic;
using Operatorok.Objektumok;

namespace Operatorok.Feladatok
{
    class NegyedikFeladat
    {
        static public void Megoldas(List<Operator> lista)
        {
            bool vanE = false;

            foreach (Operator elem in lista)
            {
                if (elem.ElsoOperandus % 10 == 0 && elem.MasodikOperandus % 10 == 0)
                {
                    vanE = true;
                    break;
                }
            }

            if (vanE)
            {
                Console.WriteLine("4. feladat: Van ilyen kifejezés!");
            }
            else
            {
                Console.WriteLine("4. feladat: Nincs ilyen kifejezés!");
            }
        }
    }
}
