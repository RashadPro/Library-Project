using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Models
{
    public class Order
    {
        [Key]
        public string OrderISBN { get; set; }
        public string NameBook { get; set; }
        public int Quantity { get; set; }
        public DateTime Date { get; set; }
        public decimal Price { get; set; }
        public string Status { get; set; }

        [ForeignKey("User")]
        [ValidateNever]
        public int UserId { get; set; }
        [ValidateNever]
        public User User { get; set; } // navigtion property

        [ValidateNever]
        public ICollection<Orderline> Orderlines { get; set; }
        [ValidateNever]
        public ICollection<Invoice> Invoices { get; set; }

    }
}
