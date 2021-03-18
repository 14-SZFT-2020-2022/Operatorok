using System;
using System.Collections.Generic;
using Operatorok.Objektumok;

namespace Operatorok.Feladatok
{
    class OtodikFeladat
    {
        static public void Megoldas(List<Operator> lista)
        {
            Dictionary<string, int> konytar = new Dictionary<string, int>();

            foreach (Operator elem in lista)
            {
                bool vanE = true;

                foreach (KeyValuePair<string, int> item in konytar)
                {
                    if (elem.Muvelet == item.Key)
                    {
                        int adat = item.Value;
                        vanE = false;
                        konytar.Remove(item.Key);
                        konytar.Add(elem.Muvelet, ++adat);
                        break;
                    }
                }

                if (vanE)
                {
                    konytar.Add(elem.Muvelet, 1);
                }
            }

            Console.WriteLine("5. feladat: Statisztika");

            foreach (KeyValuePair<string, int> elem in konytar)
            {
                if (elem.Key == "mod" || elem.Key == "div" || elem.Key == "+" || elem.Key == "-" || elem.Key == "*" || elem.Key == "/")
                {
                    Console.WriteLine($"\t{elem.Key,3} -> {elem.Value} db");
                }
            }
        }
    }
}
