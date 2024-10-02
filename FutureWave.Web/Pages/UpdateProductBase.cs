using FutureWave.Models.Dtos;
using FutureWave.Web.Services.Contracts;
using Microsoft.AspNetCore.Components;

namespace FutureWave.Web.Pages
{
    public class UpdateProductBase:ComponentBase
    {
        [Inject]
        public IProductService ProductService { get; set; }
        public string UpdateMessage { get; set; }
        public ProductDto UpdatedProduct { get; set; } = new ProductDto();
        public ProductDto UpdateProduct { get; set; } = new ProductDto();

        public async Task<ProductDto> Update()
        {

            try
            {
                UpdatedProduct = await ProductService.UpdateProduct(UpdateProduct);
                return UpdatedProduct;

                UpdateMessage = "Updated succesfully";
            }
            catch (Exception)
            {

                UpdateMessage = null;
                return default(ProductDto);
            }

           

            
        }



    }
}
