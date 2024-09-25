using ProjectFashion.Core.Interfaces.Repositories;
using ProjFashion.Core.Entities.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjFashion.Core.Interfaces.Repositories
{
    public class IProductColourRepository : IGenericRepository<ProductColor>
    {
        public IProductColourRepository()
        {
        }

        public Task<bool> Create(ProductColor entity) => throw new NotImplementedException();
        public Task<bool> Delete(long id) => throw new NotImplementedException();
        public Task<bool> DeleteByListId(List<long> listId) => throw new NotImplementedException();
        public Task<ProductColor> Get(long id) => throw new NotImplementedException();
        public Task<List<ProductColor>> GetAll() => throw new NotImplementedException();
        public Task<bool> Update(ProductColor entity) => throw new NotImplementedException();
    }
}
