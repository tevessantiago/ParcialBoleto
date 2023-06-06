using DAL.Contracts;
using DM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Memory
{
    public class VentaRepository : IGenericRepository<Venta>
    {
        List<Venta> ventas = new List<Venta>();
        public void Delete(Guid id)
        {
            ventas.RemoveAll(venta => venta.IdVenta == id);
        }

        public IEnumerable<Venta> GetAll()
        {
            return ventas;
        }

        public Venta GetOne(Guid id)
        {
            return ventas.FirstOrDefault(venta => venta.IdVenta == id);
        }

        public void Insert(Venta entity)
        {
            ventas.Add(entity);
        }

        public void Update(Guid id, Venta entity)
        {
            int index = ventas.FindIndex(venta => venta.IdVenta == id);
            if (index == -1)
            {
                ventas[index] = entity;
            }
        }
    }
}
