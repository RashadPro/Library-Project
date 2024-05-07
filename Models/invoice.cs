using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Models
{
    public class Invoice
    {
        [Key]
        public int InvoiceISBN { get; set; }
        public int CustNum { get; set; }
        public DateTime Date { get; set; }
        public int Amount { get; set; }

        [ForeignKey("Order")]
        [ValidateNever]
        public int OrderId { get; set; }
        [ValidateNever]
        public User Order { get; set; } // navigtion property
    }
}
