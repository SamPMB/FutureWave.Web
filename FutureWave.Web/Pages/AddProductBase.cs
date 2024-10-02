using FutureWave.Models.Dtos;
using FutureWave.Web.Services;
using FutureWave.Web.Services.Contracts;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace FutureWave.Web.Pages
{
    public class AddProductBase: ComponentBase
    {

        [Inject]
        public  IProductService ProductService{  get; set; }
        public ProductDto AddProduct { get; set; } = new ProductDto();
        public ProductDto AddedProduct { get; set; } = new ProductDto();
        public async Task<ProductDto> Add_button()
        {
            AddedProduct = await ProductService.AddProduct(AddProduct);
            return AddedProduct;
        }
    }
}
