namespace FutureWave.Api.Entities
{
    public class Product
    {
      public int Id { get; set; }
      public string? ProductName { get; set; }
     public string? ProductDescription { get; set; }
     public int Qty { get; set; }
    public float Price { get; set; }
    public int CategoryId { get; set; }
    public string? ImageUrl { get; set; }

    }
}
