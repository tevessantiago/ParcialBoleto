using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DM
{
    public class Ejecutivo : Boleto
    {

        public Ejecutivo()
        {
            TipoBoleto = TipoBoleto.Ejecutivo;
        }

    }
}
