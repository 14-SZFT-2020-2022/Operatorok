using System;

namespace Operatorok.Feladatok
{
    class HatodikFeladat
    {
        static public string Kiertekel(string bemenet)
        {
            string kimenet = "";

            string[] tomb = bemenet.Split(' ');

            if (tomb.Length > 1)
            {
                int elsoOp = Int32.Parse(tomb[0]);
                string muvelet = tomb[1];
                int masodikOp = Int32.Parse(tomb[2]);

                switch (muvelet)
                {
                    case "mod":
                        {
                            if (elsoOp >= masodikOp && masodikOp > 0)
                            {
                                kimenet = (elsoOp % masodikOp).ToString();
                            }
                            else
                            {
                                kimenet = "Egyéb hiba!";
                            }
                            break;
                        }
                    case "div":
                        {
                            if (elsoOp >= masodikOp && masodikOp > 0)
                            {
                                kimenet = (elsoOp / masodikOp).ToString();
                            }
                            else
                            {
                                kimenet = "Egyéb hiba!";
                            }
                            break;
                        }
                    case "/":
                        {
                            if (masodikOp > 0)
                            {
                                kimenet = ((double)elsoOp / masodikOp).ToString();
                            }
                            else
                            {
                                kimenet = "Egyéb hiba!";
                            }
                            break;
                        }
                    case "+":
                        {
                            kimenet = (elsoOp + masodikOp).ToString();
                            break;
                        }
                    case "-":
                        {
                            kimenet = (elsoOp - masodikOp).ToString();
                            break;
                        }
                    case "*":
                        {
                            kimenet = (elsoOp * masodikOp).ToString();
                            break;
                        }
                    default:
                        {
                            kimenet = "Hibás operátor!";
                            break;
                        }
                }

                return kimenet;
            }
            else
            {
                return bemenet;
            }
        }            
    }
}
