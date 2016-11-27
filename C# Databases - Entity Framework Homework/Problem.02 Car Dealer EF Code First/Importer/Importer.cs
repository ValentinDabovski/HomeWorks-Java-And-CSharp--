namespace CarDealer.Core
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using CarDealer.Core.DTO_Models;
    using CarDealer.Data;
    using CarDealer.Models;
    using Newtonsoft.Json;

    public class Importer
    {
        public void ImportSuppliers()
        {
            var context = new CarDealerContext();
            var json = File.ReadAllText(DatasetsPath.supplierPath);
            var suppliers = JsonConvert.DeserializeObject<IEnumerable<SupplierDTO>>(json);

            foreach (var supplierDto in suppliers)
            {
                if (supplierDto.Name == null)
                {
                    Console.WriteLine("Invalid Data No Supplier Name");
                    continue; ;
                }

                var supplierEntity = new PartSupplier()
                {
                    Name = supplierDto.Name,
                    ImportedParts = supplierDto.IsImporter
                };

                context.PartSuppliers.Add(supplierEntity);
                Console.WriteLine($"Successfully Imported Supplier {supplierDto.Name}");
            }
            context.SaveChanges();
        }


        public void ImportParts()
        {
            var context = new CarDealerContext();
            var json = File.ReadAllText(DatasetsPath.partPath);
            var parts = JsonConvert.DeserializeObject<IEnumerable<PartDTO>>(json);

            foreach (var partDto in parts)
            {
                if (partDto.Name == null)
                {
                    Console.WriteLine("Ivalid Data No Name!");
                    continue;
                }

                var partEntity = new Part()
                {
                    Name = partDto.Name,
                    Price = partDto.Price,
                    Quantity = partDto.Quantity,
                    Supplier = GetRandomSupplier(context)
                };

                context.Parts.Add(partEntity);
                Console.WriteLine($"Successfully Imported Part {partDto.Name}");
            }
            context.SaveChanges();
        }


        public void ImportCars()
        {
            var context = new CarDealerContext();
            var json = File.ReadAllText(DatasetsPath.carsPath);
            var cars = JsonConvert.DeserializeObject<IEnumerable<CarDTO>>(json);

            foreach (var carDto in cars)
            {
                if (carDto.Make == null)
                {
                    Console.WriteLine("Ivalid Data No Make Name!");
                    continue; ;
                }

                var carEntity = new Car()
                {
                    Make = carDto.Make,
                    Model = carDto.Model,
                    TravelledKilometers = carDto.TravelledDistance,
                    Parts = GetRandomParts(context)
                };

                context.Cars.Add(carEntity);
                Console.WriteLine($"Successfully Imported Car {carDto.Make} {carDto.Model}");
            }
            context.SaveChanges();
        }


        public void ImportCustomers()
        {
            var context = new CarDealerContext();
            var json = File.ReadAllText(DatasetsPath.customersPath);
            var customers = JsonConvert.DeserializeObject<IEnumerable<CustomerDTO>>(json);

            foreach (var customerDto in customers)
            {
                if (customerDto.Name == null)
                {
                    Console.WriteLine("Invalid Data No Customer Name!");
                    continue;
                }

                var customerEntity = new Customer()
                {
                    Name = customerDto.Name,
                    DateOfBirth = DateTime.Parse(customerDto.BirthDate),
                    IsYoungDriver = customerDto.IsYoungDriver
                };

                context.Customers.Add(customerEntity);
                Console.WriteLine($"Succesfully Imported Customer {customerDto.Name}");
            }
            context.SaveChanges();
        }

        public void ImportSales()
        {
            var context = new CarDealerContext();

            for (int i = 0; i < 100; i++)
            {
                var saleEntity = new Sale()
                {
                    Car = GetRandomCar(context),
                    Customer = GetRandomCustomer(context),
                    DiscountPercentage = GetRandomDiscountForSale()
                };
                context.Sales.Add(saleEntity);
                Console.WriteLine("Succesfully Imported Sale");

            }
            context.SaveChanges();

        }




        // Methots Extracting From DB
        //---------------------------
        //---------------------------
        //---------------------------



        private decimal GetRandomDiscountForSale()
        {
            var discountList = new List<decimal>() { 0, 5, 10, 15, 20, 30, 40, 50 };
            var random = new Random();
            var randomDiscount = random.Next(discountList.Count);
            return randomDiscount;
        }


        private Customer GetRandomCustomer(CarDealerContext context)
        {
            Random random = new Random();
            var randomCustomerId = random.Next(1, context.Customers.Count());
            return context.Customers.FirstOrDefault(c => c.Id == randomCustomerId);
        }


        private Car GetRandomCar(CarDealerContext context)
        {
            Random random = new Random();
            var randomCarId = random.Next(1, context.Cars.Count());
            return context.Cars.FirstOrDefault(c => c.Id == randomCarId);
        }


        private ICollection<Part> GetRandomParts(CarDealerContext context)
        {
            var random = new Random();
            var randomPartsHashSet = new HashSet<Part>();
            var randomNumberToRandomisePartQuantity = random.Next(2); // select between 0 and 1 

            if (randomNumberToRandomisePartQuantity == 0) // random 10 parts
            {
                for (int i = 0; i < 10; i++)
                {
                    var randomPartId = random.Next(context.Parts.Count());
                    var randomPart = context.Parts.FirstOrDefault(p => p.Id == randomPartId);
                    randomPartsHashSet.Add(randomPart);
                }
                return randomPartsHashSet;
            }

            if (randomNumberToRandomisePartQuantity == 1) // random 20 parts
            {
                for (int i = 0; i < 20; i++)
                {
                    var randomPartId = random.Next(context.Parts.Count());
                    var randomPart = context.Parts.FirstOrDefault(p => p.Id == randomPartId);
                    randomPartsHashSet.Add(randomPart);

                }
                return randomPartsHashSet;
            }
            return null;
        }


        private PartSupplier GetRandomSupplier(CarDealerContext context)
        {
            var random = new Random();
            var randomSupplierId = random.Next(1, context.PartSuppliers.Count() + 1);

            return context.PartSuppliers.FirstOrDefault(sp => sp.Id == randomSupplierId);

        }
    }
}
