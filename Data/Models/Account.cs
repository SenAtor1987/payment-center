namespace payment_center_3.Data.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string Street { get; set; } = string.Empty;
        public string House { get; set; } = string.Empty;
        public string Appartment { get; set; } = string.Empty;

        public User? User { get; set; }

        public ICollection<Bill> Bills { get; set; } = new List<Bill>();
        public ICollection<Indicactor> Indicactor { get; set; } = new List<Indicactor>();
    }
}
