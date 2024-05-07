using Library.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Library.Data
{
    public class ApplicationDpContext : DbContext
    {
        public ApplicationDpContext(DbContextOptions<ApplicationDpContext> options) : base(options)
        {

        }


        public DbSet<Author> Authors { get; set; }
        public DbSet<AuthorBook> AuthorBooks { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Orderline> Orderlines { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Order> Orders { get; set; }
   
    }
}
