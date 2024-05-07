namespace ShopModels.Models
{
    public class Shipping
    {
        public int Id { get; set; }
        public string  CarrierName{ get; set; }
        public string TrackingNumber { get; set;}
        public byte ShippingStatus { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ShippingDate { get; set; }
        public DateTime EstimatedDeliveryDate { get; set; }
        public DateTime ActualDeliveryDate { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }

}

