using DAL.Contracts;
using DAL.Tools;
using DM;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.SqlServer
{
    public class VentaRepository : IGenericRepository<Venta>
    {

        #region Statements
        private string InsertStatement
        {
            get => "INSERT INTO [dbo].[Venta] (FechaVenta, IdVenta) VALUES (@FechaVenta, @IdVenta)";
        }

        private string UpdateStatement
        {
            get => "UPDATE [dbo].[Venta] SET (FechaVenta, IdVenta) WHERE IdVenta = @IdVenta";
        }

        private string DeleteStatement
        {
            get => "DELETE FROM [dbo].[Venta] WHERE IdVenta = @IdVenta";
        }

        private string SelectOneStatement
        {
            get => "SELECT IdVenta, FechaVenta, IdVenta FROM [dbo].[Venta] WHERE IdVenta = @IdVenta";
        }

        private string SelectAllStatement
        {
            get => "SELECT IdVenta, FechaVenta, IdVenta FROM [dbo].[Venta]";
        }
        #endregion

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
            SqlHelper.ExecuteNonQuery(InsertStatement, CommandType.Text,
                new SqlParameter[]
                {
                    new SqlParameter("@FechaVenta",entity.FechaVenta),
                    new SqlParameter("@IdVenta",entity.IdVenta)
                });
        }

        public void Update(Guid id, Venta entity)
        {
            throw new NotImplementedException();
        }
    }
}
