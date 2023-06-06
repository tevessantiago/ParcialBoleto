using DAL.Contracts;
using DAL.Factory;
using DM;
using System.Diagnostics;
using System.Net;

namespace BLL
{
    public class BoletoLogic
    {
        IGenericRepository<Boleto> repositoryBoleto = Factory.Current.GetBoletoRepository();
        double costoBase = 9950;
        double incrementoEjecutivo = 8400;
        double incrementoTurista = 9800;

        public void CalcularCostoBoleto(Boleto boleto) //Falta definir default.
        {
            switch (boleto.TipoBoleto)
            {
                case TipoBoleto.Ejecutivo:
                    boleto.CostoEmbarque = costoBase + incrementoEjecutivo;
                    break;

                case TipoBoleto.Turista:
                    boleto.CostoEmbarque = costoBase + incrementoTurista;
                    break;

                default: break;
            }
        }

        public void CalcularFechaRegreso(Boleto boleto)
        {            
            boleto.FechaRegreso = boleto.FechaSalida.AddDays(boleto.TiempoEnDias);
        }

        /*public void AsignarNumero(Boleto boleto)//Esto lo tiene que hacer el repo.
        {
            boleto.Numero = ++boleto.Numero;
        }*/

        public void AsignarId(Boleto boleto)
        {
            boleto.IdBoleto = Guid.NewGuid();
        }

        public void AgregarMultiplesBoletos(List<Boleto> boletos)
        {
            foreach(var boleto in boletos)
            {
                Agregar(boleto);
            }
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