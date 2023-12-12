namespace WebAppMongoDB.Models
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string PostCode { get; set; } = null!;
        public string Country { get; set; } = null!;
    }
}
