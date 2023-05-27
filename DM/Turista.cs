using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM
{
    public class Turista : Boleto
    {
        //Turista()

        public override decimal CostoBoleto() //double
        {
            return 9950 + 8400 + CostoEmbarque;
        }

        public override DateTime CalcularRegreso()
        {
            return FechaSalida.AddDays(TiempoEnDias);
        }
    }
}
