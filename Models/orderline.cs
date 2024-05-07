using MessagePack;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Models
{
    public class Orderline
    {
        
        public int Id { get; set; }
        //foreign key
        [ForeignKey("Order")]
        public int OrderId { get; set; }
        public Order Ordere { get; set; }

        //foreign key
        [ForeignKey("Book")]
        public int BookId { get; set; }
        public Book Booke { get; set; }


    }
}
