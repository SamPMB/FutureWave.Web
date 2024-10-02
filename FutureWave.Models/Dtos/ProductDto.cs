using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureWave.Models.Dtos
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string? ProductName { get; set; }
        public string? ProductDescription { get; set; }
        public string? CategoryName { get; set;}
        public int Qty { get; set; }
        public float Price { get; set; }
        public string? ImageUrl { get; set; }
    }
}
