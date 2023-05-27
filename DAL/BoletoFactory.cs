using DM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class BoletoFactory
    {
        public static Boleto CreateTuristaBoleto(int numero, DateTime fechaSalida, int tiempoEnDias, decimal costoEmbarque)
        {
            return new Turista()
            {
                Numero = numero,
                FechaSalida = fechaSalida,
                TiempoEnDias = tiempoEnDias,
                CostoEmbarque = costoEmbarque
            };
        }

        public static Boleto CreateEjecutivoBoleto(int numero, DateTime fechaSalida, int tiempoEnDias, decimal costoEmbarque)
        {
            return new Ejecutivo()
            {
                Numero = numero,
                FechaSalida = fechaSalida,
                TiempoEnDias = tiempoEnDias,
                CostoEmbarque = costoEmbarque
            };
        }
    }
}
