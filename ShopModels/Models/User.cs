namespace ShopModels.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
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

