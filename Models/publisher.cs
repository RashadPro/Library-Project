using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class Publisher
    {
        [Key]
        public int PupISBN { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public int Phone { get; set; }
        [ValidateNever]
        public ICollection<Book> Books { get; set; }
    }
}
