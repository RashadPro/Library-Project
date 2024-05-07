using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Models
{
    public class AuthorBook
    {
        [Key]
        public int Id { get; set; }
        //foreign key
        public int AuthorId { get; set; }
        public Author Author { get; set; } // navigtion property

        //foreign key
        [ForeignKey("Book")]
        public int BookId { get; set; }
        public Book Book { get; set; } // navigtion property
    }
}
