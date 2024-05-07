namespace ShopModels.Models
{
    public class TaxType
    {
        public int Id { get; set; }
        public string TypeName { get; set; }
        public string TypeDescription { get; set; }
        public decimal TypeFees { get; set; }
        public ICollection<ProductTax>? ProductTaxes { get; set; } = new List<ProductTax>();

    }

}

