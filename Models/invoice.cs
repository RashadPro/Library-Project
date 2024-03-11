namespace Library.Models
{
    public class invoice
    {
        public int invoiceId { get; set; }
        public int cust_num { get; set; }
        public int date { get; set; }
        public int amount { get; set; }


        public payment? Payment { get; set; }

    }
}
