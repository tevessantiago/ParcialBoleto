using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM
{
    public class Venta
    {
        public DateTime FechaVenta { get; set; }
        public List<Boleto> boletosVendidos { get; set; }
        public Guid IdVenta { get; set; }
    }
}
