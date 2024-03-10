namespace Library.Models
{
    public class publisher
    {
        public int pup_ISBN { get; set; }
        public string name { get; set; }
        public string location { get; set; }
        public int phone { get; set; }

        //List Of books
        public List<book> books { get; set; }
    }
}
