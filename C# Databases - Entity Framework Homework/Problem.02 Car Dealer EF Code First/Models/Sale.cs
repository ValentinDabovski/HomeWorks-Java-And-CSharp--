
namespace CarDealer.Models
{
    public class Sale
    {

        public Sale()
        {

        }

        public int Id { get; set; }

        public decimal DiscountPercentage { get; set; }

        public virtual Car Car { get; set; }


        public virtual Customer Customer { get; set; }
    }
}
