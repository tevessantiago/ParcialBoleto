using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DM
{
    public class Ejecutivo : Boleto
    {

        public Ejecutivo()
        {
            TipoBoleto = TipoBoleto.Ejecutivo;
        }

        /*public Ejecutivo(int numero, DateTime fechaSalida, int tiempoEnDias, double costoEmbarque)
        {
            Numero = numero;
            FechaSalida = fechaSalida;
            TiempoEnDias = tiempoEnDias;
            CostoEmbarque = costoEmbarque;
        }

        public override double CostoBoleto() //A la BLL
        {
            return 9950 + 9800 + CostoEmbarque;
        }

        public override DateTime CalcularRegreso()//A la BLL
        {
            return FechaSalida.AddDays(TiempoEnDias);
        }*/
    }
}
