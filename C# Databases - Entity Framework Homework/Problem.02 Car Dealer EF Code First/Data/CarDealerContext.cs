namespace CarDealer.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using CarDealer.Models;

    public class CarDealerContext : DbContext
    {
       
        public CarDealerContext()
            : base("name=CarDealerContext")
        {
        }

        public  IDbSet<Car> Cars { get; set; }

        public IDbSet<Customer> Customers { get; set; }

        public IDbSet<Sale> Sales { get; set; }

        public IDbSet<Part> Parts { get; set; }

        public IDbSet<PartSupplier> PartSuppliers { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           

            base.OnModelCreating(modelBuilder);
        }
    }
}