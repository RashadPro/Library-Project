using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class order
    {
        [Key]
        public int order_ISBN { get; set; }
        public string namebook { get; set; }
        public int quantity { get; set; }
        public DateTime date { get; set; }
        public int price { get; set; }
        public string status { get; set; }

        public List<orderline> OrderLines { get; set; }

        //FK
        public  int invoice_ISBN { get; set; }
        public  invoice invoice { get; set; }

      
   

}
}
