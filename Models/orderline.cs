namespace Library.Models
{
    public class orderline
    {
        //foreign key
        public int order_ISBN { get; set; }
        //public order Orderes { get; set; }

        //foreign key
        public int book_ISBN { get; set; }
       // public book Bookes { get; set; }

        public decimal amount { get; set; }
    }
}
