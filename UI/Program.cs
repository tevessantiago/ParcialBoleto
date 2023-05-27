using BLL;
using DM;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese los datos del boleto turista:");
        Boleto turistaBoleto = new Turista()
        {
            Numero = 1,
            FechaSalida = DateTime.Now,
            TiempoEnDias = 7,
            CostoEmbarque = 100
        };

        Console.WriteLine("Costo del boleto turista: $" + BoletoManager.CalcularCostoBoleto(turistaBoleto));
        Console.WriteLine("Fecha de regreso del boleto turista: " + BoletoManager.CalcularFechaRegreso(turistaBoleto));

        Console.WriteLine();

        Console.WriteLine("Ingrese los datos del boleto ejecutivo:");
        Boleto ejecutivoBoleto = new Ejecutivo()
        {
            Numero = 2,
            FechaSalida = DateTime.Now,
            TiempoEnDias = 10,
            CostoEmbarque = 150
        };

        Console.WriteLine("Costo del boleto ejecutivo: $" + BoletoManager.CalcularCostoBoleto(ejecutivoBoleto));
        Console.WriteLine("Fecha de regreso del boleto ejecutivo: " + BoletoManager.CalcularFechaRegreso(ejecutivoBoleto));

        Console.ReadLine();
    }
}
