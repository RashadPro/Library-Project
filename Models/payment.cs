namespace Library.Models
{
    public class payment
    {
        public int payment_ISBN { get; set; }
        public DateTime data { get; set; }
        public int amount { get; set; }
        public string states { get; set; }


        //pk invoice
        public List<invoice> invoices { get; set; }

        //pk user
        public List<user> user { get; set; }
    }
}
