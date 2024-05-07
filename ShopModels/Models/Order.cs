namespace ShopModels.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string OrderUrl { get; set; }
        public DateTime CreateDate { get; set; }
        public string? OrderDescription { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
       

    }

}

