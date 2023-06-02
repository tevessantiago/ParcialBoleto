using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Contracts
{
    public interface IGenericRepository<T> : IGenericInsert<T>, IGenericUpdate<T>, IGenericDelete<T>, IGenericGetAll<T>, IGenericGetOne<T>
    {
        /*void Insert(T entity);

        void Update(Guid id, T entity);

        void Delete(Guid id);

        IEnumerable<T> GetAll(); //Es IEnumerable porque los filtros de Linq devuelven IEnumerable.

        T GetOne(Guid id);*/
    }
}
