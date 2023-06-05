using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM
{
    public class Turista : Boleto
    {

        public Turista()
        {
            TipoBoleto = TipoBoleto.Turista;
        }

        /*public Turista(int numero, DateTime fechaSalida, int tiempoEnDias, double costoEmbarque)
        {
            Numero = numero;
            FechaSalida = fechaSalida;
            TiempoEnDias = tiempoEnDias;
            CostoEmbarque = costoEmbarque;
        }

        public override double CostoBoleto()
        {
            return 9950 + 8400 + CostoEmbarque;
        }*/

        /*public override DateTime CalcularRegreso()
        {
            return FechaSalida.AddDays(TiempoEnDias);
        }*/
    }
}
