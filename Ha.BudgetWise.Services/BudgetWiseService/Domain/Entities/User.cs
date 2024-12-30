using Domain.Enums;

namespace Domain.Entities
{
    public class User
    {
        public User()
        {
            Purchases = new HashSet<Purchase>();
        }

        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public Gender Gender { get; set; }
        public string? Email { get; set; }
        public ICollection<Purchase> Purchases { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime LastUpdatedOn { get; set; }
    }
}
