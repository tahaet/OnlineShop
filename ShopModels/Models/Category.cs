namespace ShopModels.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string? CategoryDescription { get; set; }
        public ICollection<Product>? Products { get; set;} = new List<Product>();
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
