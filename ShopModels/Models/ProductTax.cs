namespace ShopModels.Models
{
    public class ProductTax
    {
        public int Id { get; set; }
        public decimal PaidFees { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int TaxTypeId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime DeleteDate { get; set; }
        public int CreatedByUserId { get; set; }
        public User CreatedByUser { get; set; }
        public int UpdatedByUserId { get; set; }
        public User UpdatedByUser { get; set; }
     
    }

}

