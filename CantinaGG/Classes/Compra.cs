using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CantinaGG.Classes
{
    public class Compra
    {
        public string[,] listaLanches;
        double saldoZezinho = 0;

        public double Saldo  { get { return saldoZezinho; } }

        public Compra()
        {
            saldoZezinho = 20;
            LitaDeLanches();
        }

        public bool CompraLanche(double preço)
        {
            if (preço <= saldoZezinho)
            {
                saldoZezinho -= preço;
                return true;
            }
            return false;
        }

        public void LitaDeLanches()
        {
            listaLanches = new string[2, 2]
            {
                {"Doguinho","2,00" },
                {"X-Salada","6,00" }
            };
        }
    }
}
