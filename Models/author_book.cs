namespace Library.Models
{
    public class author_book
    {
        //foreign key
        public int author_id { get; set; }
        public author author { get; set; } // navigtion property

        //foreign key
        public int book_ISBN { get; set; }
        public book book { get; set; } // navigtion property
    }
}
