namespace DM
{
    public abstract class Boleto
    {
        public Guid Id { get; set; }
        public int Numero { get; set; }
        public DateTime FechaSalida { get; set; }
        public int TiempoEnDias { get; set; }
        public double CostoEmbarque { get; set; }

        public TipoBoleto TipoBoleto { get; set; }
        //public abstract double CostoBoleto(); //A la BLL
        //public abstract DateTime CalcularRegreso(); // A la BLL
    }
}