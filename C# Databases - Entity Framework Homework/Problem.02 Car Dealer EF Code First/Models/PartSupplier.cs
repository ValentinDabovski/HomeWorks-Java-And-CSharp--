namespace CarDealer.Models
{
    using System.Collections.Generic;

    public class PartSupplier
    {
        private ICollection<Part> parts;

        public PartSupplier()
        {
            this.parts = new HashSet<Part>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public bool ImportedParts { get; set; }

        public virtual ICollection<Part> Parts
        {
            get { return this.parts; }

            set { this.parts = value; }
        }
    }
}
