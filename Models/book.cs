using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Models
{
   
    public class Book
    {
        [Key]
        public int Id { get; set; }
        public string Version { get; set; }
        public string Name { get; set; }
        public DateTime DateOfPublication { get; set; }
        public int Quantity { get; set; }
        public int PupISBN { get; set; }

        [ForeignKey("Publisher")]
        [ValidateNever]
        public int PublisherId { get; set; }
        [ValidateNever]
        public Publisher Publisher { get; set; } // navigtion property

        //List Of author_books
        [ValidateNever]
        public ICollection<AuthorBook> AuthorBooks { get; set; }
        [ValidateNever]
        public ICollection<Orderline> Orderlines { get; set; }

    }
}
