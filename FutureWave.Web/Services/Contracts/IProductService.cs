using FutureWave.Models.Dtos;

namespace FutureWave.Web.Services.Contracts
{
    public interface IProductService
    {
        public Task<IEnumerable<ProductDto>> GetProducts();
        public Task<ProductDto> DeleteProduct(int id);
        public Task<ProductDto> AddProduct(ProductDto productDto);
        public Task<ProductDto> UpdateProduct(ProductDto productDto);

       
    }
}
