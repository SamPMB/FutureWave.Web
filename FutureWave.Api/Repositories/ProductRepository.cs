using FutureWave.Api.Data;
using FutureWave.Api.Entities;
using FutureWave.Api.Repositories.Contracts;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace FutureWave.Api.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly FutureWaveDbContext futureWaveDbContext;

        public ProductRepository(FutureWaveDbContext futureWaveDbContext)
        {
            this.futureWaveDbContext = futureWaveDbContext;
        }

        public async Task<Product> AddProduct(Product product)
        {
            var addProduct = await this.futureWaveDbContext.Products.AddAsync(product);
                              await this.futureWaveDbContext.SaveChangesAsync();
            return product;
        }

        public async Task<Product> DeleteProduct(int id)
        {
            var product = await futureWaveDbContext.Products.FindAsync(id);
            if (product != null) { 
                  this.futureWaveDbContext.Products.Remove(product);
                await this.futureWaveDbContext.SaveChangesAsync();
            }
            return product;

        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            var products =  await futureWaveDbContext.Products.ToListAsync();
            return products;
        }

        public async Task<Product> UpdateProduct(Product product) {

            var updateProduct = await this.futureWaveDbContext.Products.FindAsync(product.Id);
          
               
                updateProduct.ProductName = product.ProductName;
                updateProduct.ProductDescription = product.ProductDescription;
                updateProduct.Price = product.Price;
                updateProduct.Qty = product.Qty;
                updateProduct.CategoryId = product.CategoryId;
                updateProduct.ImageUrl = product.ImageUrl;
                try
                {
                    await this.futureWaveDbContext.SaveChangesAsync();
                    return updateProduct;
                }

                catch (Exception)
                {

                    throw;
                }
            
            
            
          
        }
      
    }
}
