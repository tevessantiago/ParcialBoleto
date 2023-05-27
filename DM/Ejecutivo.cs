using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM
{
    public class Ejecutivo : Boleto
    {

        //Ejecutivo()
        public override decimal CostoBoleto() //double
        {
            return 9950 + 9800 + CostoEmbarque;
        }

        public override DateTime CalcularRegreso()
        {
            return FechaSalida.AddDays(TiempoEnDias);
        }
    }
}
