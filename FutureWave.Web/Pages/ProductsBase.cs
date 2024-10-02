using FutureWave.Models.Dtos;
using FutureWave.Web.Services.Contracts;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace FutureWave.Web.Pages
{
    public class ProductsBase:ComponentBase
    {
        [Inject]
        public IProductService productService {  get; set; }

        public IEnumerable<ProductDto> Products { get; set; }
       
        protected override async Task OnInitializedAsync()
        {
            Products = await productService.GetProducts();
           
        }

        public async Task DeleteProduct(int id) {

            var deletedProduct = await productService.DeleteProduct(id);


            return;
        
        }
      

    }
}
