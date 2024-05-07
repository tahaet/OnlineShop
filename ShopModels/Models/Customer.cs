namespace ShopModels.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public char Gender { get; set; }
        public ICollection<Address> Address { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public List<Review>? Reviews{ get; set; } = new List<Review>();
        public List<Order>? Orders{ get; set; }= new List<Order>();


    }
}
