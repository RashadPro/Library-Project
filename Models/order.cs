namespace Library.Models
{
    public class order
    {
        
        public string OrderISBN { get; set; }
        public string Namebook { get; set; }
        public int Quantity { get; set; }
        public DateTime Date { get; set; }
        public decimal Price { get; set; }
        public string Status { get; set; }

        // one to one
        public int invoice_ISBN { get; set; }
        public invoice Invoice { get; set; }

        public List <orderline> orderlines { get; set; }


        //foreign key
        public int  userId { get; set; }
        public user user { get; set; }

    }
}
