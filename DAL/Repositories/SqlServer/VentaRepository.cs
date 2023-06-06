using DAL.Contracts;
using DM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.SqlServer
{
    public class VentaRepository : IGenericRepository<Venta>
    {
        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Venta> GetAll()
        {
            throw new NotImplementedException();
        }

        public Venta GetOne(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Venta entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Guid id, Venta entity)
        {
            throw new NotImplementedException();
        }
    }
}
