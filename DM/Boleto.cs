namespace DM
{
    public abstract class Boleto
    {
        
        public int Numero { get; set; }
        public TipoBoleto TipoBoleto { get; set; }
        public DateTime FechaSalida { get; set; }
        public DateTime FechaRegreso { get; set; }
        public int TiempoEnDias { get; set; }
        public double CostoEmbarque { get; set; }
        public Guid IdBoleto { get; set; }
        public Guid IdVenta { get; set; }
        
        //public abstract double CostoBoleto(); //A la BLL
        //public abstract DateTime CalcularRegreso(); // A la BLL
    }
}