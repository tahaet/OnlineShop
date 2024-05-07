namespace ShopModels.Models
{
    public class ProductVariation
    {
        public int Id { get; set; }
        public string VariationName { get; set; }
        public int VariationAmountInStock { get; set; }
        public int ProductId { get; set; }
        public bool  IsDeleted { get; set; }
        public Product Product { get; set; }
        public ICollection<ProductImage>? ProductImages { get; set; } = new List<ProductImage>();
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

