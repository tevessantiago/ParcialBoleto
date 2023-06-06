using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM
{
    public class Venta
    {
        DateTime FechaVenta { get; set; }
        List<Boleto> boletosVendidos { get; set; }
        Guid IdVenta { get; set; }
    }
}
