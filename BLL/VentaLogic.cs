using DAL.Contracts;
using DAL.Factory;
using DM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class VentaLogic
    {
        IGenericRepository<Venta> repositoryVenta = Factory.Current.GetVentaRepository();
        BoletoLogic boletoLogic;

        /* VenderBoletos() necesita utilizar BoletoLogic para persistir los boletos a vender.
           Si creaba un objeto BoletoLogic en esta clase, no podía persistir en tiempo de ejecución.
           Se creaba un repo de Boleto cada vez que se utilizaba.
           Tuve que agregar el parámetro al constructor para que reciba el objeto BoletoLogic.
           Ahora el objeto BoletoLogic se crea en la UI y se envía al constructor de VentaLogic.
           Fue buena práctica? Sirve solo para memoria o para sql tambien? */

        public VentaLogic(BoletoLogic boletoLogic)
        {
            this.boletoLogic = boletoLogic; 
        }
        public void VenderBoletos(List<Boleto> boletos)
        {
            Venta venta = new Venta();
            venta.IdVenta = Guid.NewGuid();
            foreach(Boleto boleto in boletos)
            {
                boleto.IdVenta = venta.IdVenta;
            }
            boletoLogic.AgregarMultiplesBoletos(boletos);
            Agregar(venta);

        }

        /*public void AsignarId(Venta venta)
        {
            venta.IdVenta = Guid.NewGuid();
        }*/

        public void Actualizar(Guid id, Venta unaVenta)
        {
            repositoryVenta.Update(id, unaVenta);
        }

        public void Agregar(Venta unaVenta)
        {
            repositoryVenta.Insert(unaVenta);
        }

        public Venta Buscar(Guid id)
        {
            return repositoryVenta.GetOne(id);
        }

        public void Eliminar(Guid id)
        {
            repositoryVenta.Delete(id);
        }

        public IEnumerable<Venta> ListarTodos()
        {
            return repositoryVenta.GetAll();
        }
    }
}
