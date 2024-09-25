using ProjFashion.Core.Entities.Products;

namespace ProjFashion.Core.Interfaces.Repositories
{
    public class IProductSizeRepository : IGenericRepository<ProductColorSize>
    {
        public Task<bool> Create(ProductColorSize entity) => throw new NotImplementedException();
        public Task<bool> Delete(long id) => throw new NotImplementedException();
        public Task<bool> DeleteByListId(List<long> listId) => throw new NotImplementedException();
        public Task<ProductColorSize> Get(long id) => throw new NotImplementedException();
        public Task<List<ProductColorSize>> GetAll() => throw new NotImplementedException();
        public Task<bool> Update(ProductColorSize entity) => throw new NotImplementedException();
    }
}
