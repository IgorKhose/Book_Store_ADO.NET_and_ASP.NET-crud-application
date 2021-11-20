using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace BookStoreCodeFirstFromDB
{
    public partial class BookStoreContext : DbContext
    {
        public BookStoreContext()
            : base("name=BookStoreConnection")
        {
        }

        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
