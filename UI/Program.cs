using BLL;
using DAL.Contracts;
using DAL.Factory;
using DM;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        //IGenericRepository<Boleto> repositoryBoleto = Factory.Current.GetBoletoRepository();
        //IBoletoRepository repository = new BoletoRepository();
        BoletoLogic venta = new BoletoLogic();

        Console.WriteLine("¿Qué desea hacer?");
        Console.WriteLine("1. Buscar un boleto");
        Console.WriteLine("2. Actualizar un boleto");
        Console.WriteLine("3. Ver todos los boletos");
        Console.WriteLine("4. Eliminar un boleto");
        Console.WriteLine("5. Vender un boleto");
        Console.Write("Ingrese el número de la opción: ");

        if (!int.TryParse(Console.ReadLine(), out int opcion))
        {
            throw new Exception("Debe ingresar un valor entero.");
        }        

        switch (opcion)
        {
            case 1:
                Console.Write("Ingrese el número del boleto a buscar: ");

                if (!int.TryParse(Console.ReadLine(), out int numeroBoleto))
                {
                    throw new Exception("Debe ingresar un valor entero.");
                }

                Boleto boletoEncontrado = venta.Buscar(numeroBoleto);
                if (boletoEncontrado != null)
                {
                    MostrarBoleto(boletoEncontrado);
                }
                else
                {
                    Console.WriteLine("No se encontró ningún boleto con ese número.");
                }
                break;

            case 2:
                Console.Write("Ingrese el número del boleto a actualizar: ");

                if (!int.TryParse(Console.ReadLine(), out int numeroActualizar))
                {
                    throw new Exception("Debe ingresar un valor entero.");
                }

                Boleto boletoActualizar = venta.Buscar(numeroActualizar);

                if (boletoActualizar != null)
                {
                    ActualizarBoleto(boletoActualizar);
                    venta.Actualizar(boletoActualizar);
                    Console.WriteLine("El boleto se actualizó correctamente.");
                }
                else
                {
                    Console.WriteLine("No se encontró ningún boleto con ese número.");
                }
                break;

            case 3:
                List<Boleto> boletos = venta.ListarTodos();
                foreach (Boleto boleto in boletos)
                {
                    MostrarBoleto(boleto);
                }
                break;

            case 4:
                Console.Write("Ingrese el número del boleto a eliminar: ");
                int numeroEliminar = Convert.ToInt32(Console.ReadLine());
                Boleto boletoEliminar = venta.Buscar(numeroEliminar);
                if (boletoEliminar != null)
                {
                    venta.Eliminar(boletoEliminar);
                    Console.WriteLine("El boleto se eliminó correctamente.");
                }
                else
                {
                    Console.WriteLine("No se encontró ningún boleto con ese número.");
                }
                break;

            case 5:
                Console.WriteLine("¿Es turista o ejecutivo?");
                Console.WriteLine("1. Turista");
                Console.WriteLine("2. Ejecutivo");
                Console.Write("Ingrese el número de la opción: ");
                int tipoVenta = Convert.ToInt32(Console.ReadLine());
                if (tipoVenta == 1)
                {
                    Turista turista = CrearBoletoTurista();
                    venta.Agregar(turista);
                    Console.WriteLine("El boleto turista se agregó correctamente.");
                }
                else if (tipoVenta == 2)
                {
                    Ejecutivo ejecutivo = CrearBoletoEjecutivo();
                    venta.Agregar(ejecutivo);
                    Console.WriteLine("El boleto ejecutivo se agregó correctamente.");
                }
                else
                {
                    Console.WriteLine("Opción inválida.");
                }
                break;

            default:
                Console.WriteLine("Opción inválida.");
                break;
        }

        Console.ReadLine();
    }

    static void MostrarBoleto(Boleto boleto)
    {
        Console.WriteLine("Boleto número: " + boleto.Numero);
        Console.WriteLine("Fecha de salida: " + boleto.FechaSalida.ToString("dd/MM/yyyy"));
        Console.WriteLine("Tiempo en días: " + boleto.TiempoEnDias);
        Console.WriteLine("Costo de embarque: " + boleto.CostoEmbarque.ToString("C"));
        Console.WriteLine("Fecha de regreso: " + boleto.CalcularRegreso().ToString("dd/MM/yyyy"));
        Console.WriteLine("--------------------------------------------");
    }

    static Turista CrearBoletoTurista()
    {
        Console.WriteLine("Creando boleto turista...");
        Console.Write("Ingrese la fecha de salida (dd/mm/aaaa): ");
        DateTime fechaSalida = Convert.ToDateTime(Console.ReadLine());
        Console.Write("Ingrese el tiempo en días: ");
        int tiempoEnDias = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingrese el costo de embarque: ");
        decimal costoEmbarque = Convert.ToDecimal(Console.ReadLine());

        return new Turista
        {
            FechaSalida = fechaSalida,
            TiempoEnDias = tiempoEnDias,
            CostoEmbarque = costoEmbarque
        };
    }

    static Ejecutivo CrearBoletoEjecutivo()
    {
        Console.WriteLine("Creando boleto ejecutivo...");
        Console.Write("Ingrese la fecha de salida (dd/mm/aaaa): ");
        DateTime fechaSalida = Convert.ToDateTime(Console.ReadLine());
        Console.Write("Ingrese el tiempo en días: ");
        int tiempoEnDias = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingrese el costo de embarque: ");
        decimal costoEmbarque = Convert.ToDecimal(Console.ReadLine());

        return new Ejecutivo
        {
            FechaSalida = fechaSalida,
            TiempoEnDias = tiempoEnDias,
            CostoEmbarque = costoEmbarque
        };
    }

    static void ActualizarBoleto(Boleto boleto)
    {
        Console.WriteLine("Actualizando boleto...");
        Console.Write("Ingrese la fecha de salida (dd/mm/aaaa): ");
        if(!DateTime.TryParse(Console.ReadLine(), out DateTime fechaSalida))
        {
            throw new Exception("Debe ingresar un valor en formato dd/mm/aaaa.");
        }

        //DateTime fechaSalida = Convert.ToDateTime(Console.ReadLine());
        Console.Write("Ingrese el tiempo en días: ");
        if (!int.TryParse(Console.ReadLine(), out int tiempoEnDias))
        {
            throw new Exception("Debe ingresar un valor entero.");
        }

        Console.Write("Ingrese el costo de embarque: ");
        decimal costoEmbarque = Convert.ToDecimal(Console.ReadLine());

        boleto.FechaSalida = fechaSalida;
        boleto.TiempoEnDias = tiempoEnDias;
        boleto.CostoEmbarque = costoEmbarque;
    }
}

