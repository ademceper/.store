public class ProductImage : BaseEntity
{
    public Guid ProductId { get; set; }
    public Product Product { get; set; }
    public string ImageUrl { get; set; }  // Fotoğraf URL'si
    public bool IsPrimary { get; set; }  // Fotoğrafın ana fotoğraf olup olmadığı
}
