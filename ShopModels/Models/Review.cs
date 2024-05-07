namespace ShopModels.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string ReviewUrl { get; set;}
        public string? ReviewText { get; set; }
        public float Rating { get; set; }
        public DateTime ReviewDate { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }

}

