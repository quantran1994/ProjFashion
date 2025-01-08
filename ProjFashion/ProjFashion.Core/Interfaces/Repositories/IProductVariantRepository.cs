using ProjectFashion.Core.Interfaces.Repositories;
using ProjFashion.Core.Entities.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjFashion.Core.Interfaces.Repositories
{
    public class IProductVariantRepository : IGenericRepository<ProductVariant>
    {
        public IProductVariantRepository()
        {
        }

        public Task<bool> Create(ProductVariant entity) => throw new NotImplementedException();
        public Task<bool> Delete(long id) => throw new NotImplementedException();
        public Task<bool> DeleteByListId(List<long> listId) => throw new NotImplementedException();
        public Task<ProductVariant> Get(long id) => throw new NotImplementedException();
        public Task<List<ProductVariant>> GetAll() => throw new NotImplementedException();
        public Task<bool> Update(ProductVariant entity) => throw new NotImplementedException();
    }
}
