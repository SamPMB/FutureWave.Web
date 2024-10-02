using FutureWave.Models.Dtos;
using FutureWave.Web.Services.Contracts;
using System.Net.Http.Json;

namespace FutureWave.Web.Services
{
    public class ProductService : IProductService
    {

        private readonly HttpClient httpClient;

        public ProductService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<ProductDto> AddProduct(ProductDto productDto)
        {
            var response = await httpClient.PostAsJsonAsync($"Api/Product/add",productDto);

            if (response.IsSuccessStatusCode)
            {

                return await response.Content.ReadFromJsonAsync<ProductDto>();

            }
            else {

                throw new Exception();
            
            }
        }

        public async Task<ProductDto> DeleteProduct(int id)
        {
           
            try
            {
                var response = await httpClient.DeleteAsync($"Api/Product/delete/{id}");
                if (response.IsSuccessStatusCode) {
                    return await response.Content.ReadFromJsonAsync<ProductDto>();
                }
                return default(ProductDto);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<IEnumerable<ProductDto>> GetProducts()
        {
            try
            {
                var products = await this.httpClient.GetFromJsonAsync<IEnumerable<ProductDto>>("Api/Product");
                return products;
            }
            catch (Exception)
            {

                throw;
            }

            
        }

        public async Task<ProductDto> UpdateProduct(ProductDto productDto)
        {

           


                var response = await this.httpClient.PostAsJsonAsync($"Api/Product/update", productDto);

                if (response.IsSuccessStatusCode)
                {

                    return await response.Content.ReadFromJsonAsync<ProductDto>();


            }
            else {  
                
                throw new Exception();
            }




            }
          



            
        }
    }

