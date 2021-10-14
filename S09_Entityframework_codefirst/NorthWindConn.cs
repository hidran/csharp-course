using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace S09_Entityframework_codefirst
{
    public partial class NorthWindConn : DbContext
    {
        public NorthWindConn()
            : base("name=NorthWindConn")
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
       // public virtual DbSet<Order> Orders { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .Property(e => e.CustomerID)
                .IsFixedLength();
        }
    }
}
