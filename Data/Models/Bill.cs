namespace payment_center_3.Data.Models
{
    public class Bill
    {
        public int Id { get; set; }
        public decimal Sum { get; set; }
        public DateTime Date { get; set; }
        public Account Account { get; set; }
    }
}
