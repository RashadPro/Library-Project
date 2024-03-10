namespace Library.Models
{
    public class user
    {
        public int ISBN { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        public int age { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public int phone { get; set; }


        //pk payment
        public List <payment> payments { get; set; }
        //invoice
        public List <invoice> invoices { get; set; }
        //prder
        public List <order> orders { get; set; }
    }
}
