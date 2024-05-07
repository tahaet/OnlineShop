namespace ShopModels.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public decimal TotalTaxesInOrder { get; set; }
        public decimal ShippingFees { get; set; }
        public decimal PaidAmount { get; set; }
        public DateTime TransactionDate { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public string PaymentMethod { get; set; }
    }

}

