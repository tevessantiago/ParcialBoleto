using DAL.Contracts;
using DM;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Factory
{
	public sealed class Factory
	{
		private readonly static Factory _instance = new Factory();

		public string backend; //Acá se guarda el valor del repositorio a utilizar.

		public static Factory Current
		{
			get
			{
				return _instance;
			}
		}

		private Factory()
		{
            //Implent here the initialization of your singleton
			//Faltaría una validación.
            backend = ConfigurationManager.AppSettings["backend"]; //Toma valor del config file.
        }

        public IGenericRepository<Boleto> GetBoletoRepository()
        {
			switch (backend)
			{
				case "SqlServer": return new Repositories.SqlServer.BoletoRepository();
                case "Memory": return new Repositories.Memory.BoletoRepository();
				default: return new Repositories.Memory.BoletoRepository();
            }
        }

		public IGenericRepository<Venta> GetVentaRepository()
		{
            switch (backend)
            {
                case "SqlServer": return new Repositories.SqlServer.VentaRepository();
                case "Memory": return new Repositories.Memory.VentaRepository();
                default: return new Repositories.Memory.VentaRepository();
            }
        }
    }

}
