using DAL.Contracts;
using DAL.Tools;
using DM;
using System;
using System.Collections.Generic;
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
            get => "INSERT INTO [dbo].[Boleto] (FechaSalida, TiempoEnDias, CostoEmbarque) VALUES (@FechaSalida, @TiempoEnDias, @CostoEmbarque)";
        }

        private string UpdateStatement
        {
            get => "UPDATE [dbo].[Boleto] SET (FechaSalida, TiempoEnDias, CostoEmbarque) WHERE Numero = @Numero";
        }

        private string DeleteStatement
        {
            get => "DELETE FROM [dbo].[Boleto] WHERE Numero = @Numero";
        }

        private string SelectOneStatement
        {
            get => "SELECT Numero, FechaSalida, TiempoEnDias, CostoEmbarque FROM [dbo].[Boleto] WHERE Numero = @Numero";
        }

        private string SelectAllStatement
        {
            get => "SELECT Numero, FechaSalida, TiempoEnDias, CostoEmbarque FROM [dbo].[Boleto]";
        }
        #endregion


        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Boleto> GetAll()
        {
            throw new NotImplementedException();
        }

        public Boleto GetOne(Guid id)
        {
            Boleto boletos = default;

            using (var dr = SqlHelper.ExecuteReader(SelectOneStatement, System.Data.CommandType.Text,
                new SqlParameter[] { new SqlParameter("@Numero", id) }))
            {
                if (dr.Read())
                {
                    //Se obtienen los valores de los campos
                    object[] values = new object[dr.FieldCount];
                    dr.GetValues(values);

                    //DATA MAPPER FechaSalida, TiempoEnDias, CostoEmbarque
                    //boletos = new Boleto();
                    

                }
            }
            return boletos;
        }

        public void Insert(Boleto entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Guid id, Boleto entity)
        {
            throw new NotImplementedException();
        }
    }
}
