using DAL.Contracts;
using DM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Memory
{
    internal class BoletoRepository : IGenericRepository<Boleto>
    {
        List<Boleto> boletos = new List<Boleto>();

        public void Delete(int id)
        {
            boletos.RemoveAll(boleto => boleto.Numero == id);
        }

        public IEnumerable<Boleto> GetAll()
        {
            return boletos;
        }

        public Boleto GetOne(int id)
        {
            return boletos.FirstOrDefault(o => o.Numero == id);
        }

        public void Insert(Boleto entity)
        {
            boletos.Add(entity);
        }

        public void Update(int id, Boleto entity)
        {
            int index = boletos.FindIndex(boleto => boleto.Numero == id);
            if(index == -1)
            {
                boletos[index] = entity;
            }
        }
    }
}
