using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class author
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string address { get; set; }
        public string Email { get; set; }
        public int phone { get; set; }
        public string country { get; set; }

        //List Of author_books
        public List<author_book> author_books { get; set; }
    }
}
