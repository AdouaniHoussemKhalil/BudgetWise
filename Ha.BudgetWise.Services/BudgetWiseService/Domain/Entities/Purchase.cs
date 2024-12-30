namespace Domain.Entities
{
    public class Purchase
    {
        public Purchase()
        {
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public User User { get; set; }
        public Guid UserId { get; set; }
        public int Quantity { get; set; }
        public int OnePieceAmount { get; set; }
        public float? TotalAmount
        {
            get
            {
                return OnePieceAmount * Quantity;
            }
        }
        public DateTime SaleOn { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime LastUpdateOn { get; set; }
    }
}
