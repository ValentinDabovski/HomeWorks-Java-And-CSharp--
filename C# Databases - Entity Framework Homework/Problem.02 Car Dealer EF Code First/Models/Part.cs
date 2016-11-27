namespace CarDealer.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Part
    {
        private ICollection<Car> cars;
        private PartSupplier supplier;
        public Part()
        {
            this.cars = new HashSet<Car>();
            this.supplier = new PartSupplier();

        }

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public ICollection<Car> Cars
        {
            get { return this.cars; }
            set { this.cars = value; }
        }

        public virtual PartSupplier Supplier
        {
            get { return this.supplier; }
            set { this.supplier = value; }
        }
    }
}
