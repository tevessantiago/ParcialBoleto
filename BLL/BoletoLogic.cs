using DAL.Contracts;
using DAL.Factory;
using DM;
using System.Net;

namespace BLL
{
    public class BoletoLogic
    {
        IGenericRepository<Boleto> repositoryBoleto = Factory.Current.GetBoletoRepository();

        public static double CalcularCostoBoleto(Boleto boleto)
        {


            return 69;
        }

        public static DateTime CalcularFechaRegreso(Boleto boleto)
        {
            return boleto.FechaSalida;
        }

        public void Actualizar(int id, Boleto unBoleto) 
        {
            repositoryBoleto.Update(id, unBoleto);
        }

        public void Agregar(Boleto unBoleto)
        {
            repositoryBoleto.Insert(unBoleto);
        }

        public Boleto Buscar(int numeroBoleto)
        {            
            return repositoryBoleto.GetOne(numeroBoleto);            
        }

        public void Eliminar(int numeroBoleto)
        {
            repositoryBoleto.Delete(numeroBoleto);
        }

        public IEnumerable<Boleto> ListarTodos()
        {
            return repositoryBoleto.GetAll();
        }
    }
}