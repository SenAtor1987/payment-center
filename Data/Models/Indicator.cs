namespace payment_center_3.Data.Models
{
    public class Indicactor
    {
        public string Type { get; set; }
        public int Value { get; set; }
        public DateTime Date { get; set; }

        public Account Account { get; set; } = new Account();
    }
}
