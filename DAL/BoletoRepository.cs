using DM;

namespace DAL
{
    public class BoletoRepository
    {
        private List<Boleto> boletos;

        public BoletoRepository()
        {
            boletos = new List<Boleto>();
        }

        public void Add(Boleto boleto)
        {
            boletos.Add(boleto);
        }

        public IEnumerable<Boleto> GetAll()
        {
            return boletos;
        }
    }
}