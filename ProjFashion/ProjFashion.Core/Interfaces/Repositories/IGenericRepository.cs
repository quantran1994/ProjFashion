using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFashion.Core.Interfaces.Repositories
{
    public interface IGenericRepository<T>
    {
        Task<T> Get(long id);
        Task<List<T>> GetAll();
        Task<bool> Create(T entity);
        Task<bool> Update(T entity);
        Task<bool> Delete(long id);
        Task<bool> DeleteByListId(List<long> listId);
    }
}
