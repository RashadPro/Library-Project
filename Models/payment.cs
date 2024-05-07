using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Models
{
    public class Payment
    {
        [Key]
        public int PaymentISBN { get; set; }
        public DateTime Data { get; set; }
        public int Amount { get; set; }
        public string States { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; } // navigtion property

    }
}
