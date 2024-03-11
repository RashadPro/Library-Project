namespace Library.Models
{
    public class payment
    {
        public int paymentId { get; set; }
        public DateTime data { get; set; }
        public int amount { get; set; }
        public string states { get; set; }

        // FK 
        public int invoiceId { get; set; }
        public invoice invoice { get; set; } // ref nav


    }
}
