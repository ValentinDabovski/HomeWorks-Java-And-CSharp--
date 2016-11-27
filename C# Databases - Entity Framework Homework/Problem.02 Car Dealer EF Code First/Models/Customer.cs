namespace CarDealer.Models
{
    using System;
    public class Customer
    {

        public Customer()
        {

        }

        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime DateOfBirth { get; set; }

        public bool IsYoungDriver { get; set; }
    }
}
