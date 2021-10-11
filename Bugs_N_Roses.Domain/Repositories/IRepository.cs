using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bugs_N_Roses.Domain.Repositories
{
    public interface IRepository<T>  where T : class
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);
        T Get(int id);
        IList<T> GetAll();

    }
}
