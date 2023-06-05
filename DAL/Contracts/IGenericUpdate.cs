using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Contracts
{
    public interface IGenericUpdate<T>
    {
        void Update(int id, T entity);
    }

}
