namespace Library.Models
{
    public class book
    {
        public int book_ISBN { get; set; }
        public string version { get; set; }
        public string name { get; set; }
        public DateTime date_of_publication { get; set; }
        public int quantity { get; set; }
        public publisher Publisher { get; set; }
        public int pup_ISBN { get; set; }


        public booktype BookType { get; set; }

        //List Of author_books
        public List<author_book> Author_Book { get; set; }

    }
}
