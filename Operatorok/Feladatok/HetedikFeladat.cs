using System;

namespace Operatorok.Feladatok
{
    class HetedikFeladat
    {
        static public void Megoldas()
        {
            string beker = "7. feladat: Kérek egy kifejezést (pl: 1 + 1): ";
            string bemenet = "";

            while (bemenet != "Vége")
            {
                Console.Write(beker);
                bemenet = Console.ReadLine();
                string eredmeny = HatodikFeladat.Kiertekel(bemenet);
                if (bemenet != "Vége")
                {
                    Console.WriteLine($"\t{bemenet} = {eredmeny}");
                }
            }
        }
    }
}
