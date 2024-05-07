namespace ShopModels.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string? Description { get; set; }
        public int QuantityInStock { get; set; }
        public bool IsDeleted { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<ProductVariation>? ProductVariations { get; set; } = new List<ProductVariation>();
        public ICollection<ProductImage>? ProductImages { get; set; } = new List<ProductImage>();
        public ProductTax ProductTax{ get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime DeleteDate { get; set; }
        public int CreatedByUserId { get; set; }
        public User CreatedByUser { get; set; }
        public int UpdatedByUserId { get; set; }
        public User UpdatedByUser { get; set; }
        public int DeletedByUserId { get; set; }
        public User DeletedByUser { get; set; }


    }

}

