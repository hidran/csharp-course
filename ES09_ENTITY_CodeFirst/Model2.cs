using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ES09_ENTITY_CodeFirst
{
    public partial class Model2 : DbContext
    {
        public Model2()
            : base("name=NorthwindCodeFirst")
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .Property(e => e.CustomerID)
                .IsFixedLength();
        }
    }
}
