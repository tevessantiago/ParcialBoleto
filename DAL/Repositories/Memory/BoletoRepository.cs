using DAL.Contracts;
using DM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Memory
{
    public class BoletoRepository : IGenericRepository<Boleto>
    {
        List<Boleto> boletos = new List<Boleto>();

        public void Delete(Guid id)
        {
            boletos.RemoveAll(boleto => boleto.IdBoleto == id);
        }

        public IEnumerable<Boleto> GetAll()
        {
            return boletos;
        }

        public Boleto GetOne(Guid id)
        {
            return boletos.FirstOrDefault(boleto => boleto.IdBoleto == id);
        }

        public void Insert(Boleto entity)
        {
            entity.Numero = boletos.Count() + 1; 
            boletos.Add(entity);
        }

        public void Update(Guid id, Boleto entity)
        {
            int index = boletos.FindIndex(boleto => boleto.IdBoleto == id);
            if(index == -1)
            {
                boletos[index] = entity;
            }
        }
    }
}
