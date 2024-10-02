using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FutureWave.Api.Entities;
using FutureWave.Models.Dtos;
using FutureWave.Api.Repositories.Contracts;

namespace FutureWave.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository productRepository;

        public ProductController( IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductDto>>> GetProducts()
        {

            try
            {
                var products = await productRepository.GetProducts();
                return Ok(products);


            }
            catch (Exception)
            {

                throw;
            }

        }
        [HttpDelete("delete/{id:int}")]
        public  async Task<ActionResult<Product>> DeleteProduct(int id)
        {
            var product = await this.productRepository.DeleteProduct(id);
            return Ok(product);

        }
        [HttpPost("add")]
        public async Task<ActionResult<Product>> AddProduct(Product product) {

            var productDto = await this.productRepository.AddProduct(product);
            return Ok(productDto);
        }

        [HttpPost("update")]
        public async Task<ActionResult<Product>> UpdateProduct( Product product) { 
        
         var updateProduct = await this.productRepository.UpdateProduct(product);
            return Ok(updateProduct);
        
        
        
        }













    }
}
