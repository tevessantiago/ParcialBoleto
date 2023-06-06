using DAL.Contracts;
using DAL.Tools;
using DM;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.SqlServer
{
    public class BoletoRepository : IGenericRepository<Boleto>
    {


        #region Statements
        private string InsertStatement
        {
            get => "INSERT INTO [dbo].[Boleto] (TipoBoleto, FechaSalida, FechaRegreso, TiempoEnDias, CostoEmbarque, IdBoleto, IdVenta) VALUES (@TipoBoleto, @FechaSalida, @FechaRegreso, @TiempoEnDias, @CostoEmbarque, @IdBoleto, @IdVenta)";
        }

        private string UpdateStatement
        {
            get => "UPDATE [dbo].[Boleto] SET (TipoBoleto, FechaSalida, FechaRegreso, TiempoEnDias, CostoEmbarque, IdBoleto, IdVenta) WHERE IdBoleto = @IdBoleto";
        }

        private string DeleteStatement
        {
            get => "DELETE FROM [dbo].[Boleto] WHERE IdBoleto = @IdBoleto";
        }

        private string SelectOneStatement
        {
            get => "SELECT IdBoleto, Numero, TipoBoleto, FechaSalida, FechaRegreso, TiempoEnDias, CostoEmbarque, IdBoleto, IdVenta FROM [dbo].[Boleto] WHERE IdBoleto = @IdBoleto";
        }

        private string SelectAllStatement
        {
            get => "SELECT IdBoleto, Numero, TipoBoleto, FechaSalida, FechaRegreso, TiempoEnDias, CostoEmbarque, IdBoleto, IdVenta FROM [dbo].[Boleto]";
        }
        #endregion


        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Boleto> GetAll()
        {
            List<Boleto> boletos = new List<Boleto>();

            using(var dr = SqlHelper.ExecuteReader(SelectAllStatement, CommandType.Text))
            {
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        switch (int.Parse(dr["TipoBoleto"].ToString()))
                        {
                            case 0:
                                boletos.Add(new Turista
                                {
                                    Numero = int.Parse(dr["Numero"].ToString()),
                                    FechaSalida = DateTime.Parse(dr["FechaSalida"].ToString()),
                                    FechaRegreso = DateTime.Parse(dr["FechaRegreso"].ToString()),
                                    TiempoEnDias = int.Parse(dr["TiempoEnDias"].ToString()),
                                    CostoEmbarque = double.Parse(dr["CostoEmbarque"].ToString()),
                                    IdBoleto = Guid.Parse(dr["IdBoleto"].ToString()),
                                    IdVenta = Guid.Parse(dr["IdVenta"].ToString())
                                });
                                break;
                            case 1:
                                boletos.Add(new Ejecutivo
                                {
                                    Numero = int.Parse(dr["Numero"].ToString()),
                                    FechaSalida = DateTime.Parse(dr["FechaSalida"].ToString()),
                                    FechaRegreso = DateTime.Parse(dr["FechaRegreso"].ToString()),
                                    TiempoEnDias = int.Parse(dr["TiempoEnDias"].ToString()),
                                    CostoEmbarque = double.Parse(dr["CostoEmbarque"].ToString()),
                                    IdBoleto = Guid.Parse(dr["IdBoleto"].ToString()),
                                    IdVenta = Guid.Parse(dr["IdVenta"].ToString())
                                });
                                break;
                            default: 
                                break;
                        }
                    }
                }
            }
            return boletos;
        }

        public Boleto GetOne(Guid id)
        {
            Boleto boleto = default;

            using (var dr = SqlHelper.ExecuteReader(SelectOneStatement, CommandType.Text,
                new SqlParameter[] { new SqlParameter("@IdBoleto", id) }))
            {
                if (dr.Read())
                {
                    //Se obtienen los valores de los campos
                    object[] values = new object[dr.FieldCount];
                    dr.GetValues(values);

                    switch (int.Parse(values[1].ToString())) //Checkea tipo de registro
                    {
                        case 1:
                            Ejecutivo ejecutivo = new Ejecutivo();
                            ejecutivo.Numero = int.Parse(values[0].ToString());
                            ejecutivo.FechaSalida = DateTime.Parse(values[2].ToString());
                            ejecutivo.FechaRegreso = DateTime.Parse(values[3].ToString());
                            ejecutivo.TiempoEnDias = int.Parse((string)values[4].ToString());
                            ejecutivo.CostoEmbarque = double.Parse(values[5].ToString());
                            ejecutivo.IdBoleto = Guid.Parse(values[6].ToString());
                            ejecutivo.IdVenta = Guid.Parse(values[7].ToString());
                            boleto = ejecutivo;
                            break;
                        case 0:
                            Turista turista = new Turista();
                            turista.Numero = int.Parse(values[0].ToString());
                            turista.FechaSalida = DateTime.Parse(values[2].ToString());
                            turista.FechaRegreso = DateTime.Parse(values[3].ToString());
                            turista.TiempoEnDias = int.Parse((string)values[4].ToString());
                            turista.CostoEmbarque = double.Parse(values[5].ToString());
                            turista.IdBoleto = Guid.Parse(values[6].ToString());
                            turista.IdVenta = Guid.Parse(values[7].ToString());
                            boleto = turista;
                            break;
                        default: break;
                    }                    
                }
            }
            return boleto;
        }

        public void Insert(Boleto entity)
        {
            SqlHelper.ExecuteNonQuery(InsertStatement, CommandType.Text,
                new SqlParameter[]
                {
                    new SqlParameter("@TipoBoleto", entity.TipoBoleto),
                    new SqlParameter("@FechaSalida", entity.FechaSalida),
                    new SqlParameter("@FechaRegreso", entity.FechaRegreso),
                    new SqlParameter("@TiempoEnDias", entity.TiempoEnDias),
                    new SqlParameter("@CostoEmbarque", entity.CostoEmbarque),
                    new SqlParameter("@IdBoleto", entity.IdBoleto),
                    new SqlParameter("@IdVenta",entity.IdVenta)
                });
        }

        public void Update(Guid id, Boleto entity)
        {
            throw new NotImplementedException();
        }
    }
}
