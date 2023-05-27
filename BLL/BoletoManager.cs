using DM;

namespace BLL
{
    public class BoletoManager
    {
        public static decimal CalcularCostoBoleto(Boleto boleto)
        {
            return boleto.CostoBoleto();
        }

        public static DateTime CalcularFechaRegreso(Boleto boleto)
        {
            return boleto.CalcularRegreso();
        }
    }
}