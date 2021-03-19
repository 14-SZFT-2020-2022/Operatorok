using System;
using System.Collections.Generic;

namespace Operatorok.Objektumok
{
    class Operator
    {
        public int ElsoOperandus { get; set; }
        public string Muvelet { get; set; }
        public int MasodikOperandus { get; set; }

        public Operator(string elsoOperandus, string muvelet, string masodikOperandus)
        {
            this.ElsoOperandus = Convert.ToInt32(elsoOperandus);
            this.Muvelet = muvelet;
            this.MasodikOperandus = Convert.ToInt32(masodikOperandus);
        }

        static public List<Operator> OperatorListaLetrehozasa(List<string[]> lista)
        {
            List<Operator> operatorLista = new List<Operator>();

            foreach (string[] elem in lista)
            {
                Operator op = new Operator(elem[0], elem[1], elem[2]);
                operatorLista.Add(op);
            }

            return operatorLista;
        }
    }
}
