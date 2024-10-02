using FutureWave.Api.Entities;

namespace FutureWave.Api.Repositories.Contracts
{
    public interface IProductRepository
    {
        public Task<IEnumerable<Product>> GetProducts();
        public Task<Product> DeleteProduct(int id);
        public Task<Product> AddProduct(Product product);
        public Task<Product> UpdateProduct( Product product);
        
    }
}
