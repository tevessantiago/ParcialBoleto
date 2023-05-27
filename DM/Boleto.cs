namespace DM
{
    public abstract class Boleto
    {
        public int Numero { get; set; }// Cambiar int a id unico
        public DateTime FechaSalida { get; set; }
        public int TiempoEnDias { get; set; }
        public decimal CostoEmbarque { get; set; } //double

        //Boleto(int numeroBoleto)

        public abstract decimal CostoBoleto(); //double
        public abstract DateTime CalcularRegreso();
    }
}