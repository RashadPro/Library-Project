namespace Library.Models
{
    public class invoice
    {
        public int invoice_ISBN { get; set; }
        public int cust_num { get; set; }
        public int date { get; set; }
        public int amount { get; set; }
        //pk payment
        public List<payment> Payments { get; set; }

    }
}
