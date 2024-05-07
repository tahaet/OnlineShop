namespace ShopModels.Models
{
    public class ProductImage
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public int ImageOrder { get; set; }
        public int ProductID { get; set; }
        public bool IsDeleted { get; set; }
        public Product Product { get; set; }    
        public int ProductVariationId { get; set; }
        public ProductVariation ProductVariation { get; set; }
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

