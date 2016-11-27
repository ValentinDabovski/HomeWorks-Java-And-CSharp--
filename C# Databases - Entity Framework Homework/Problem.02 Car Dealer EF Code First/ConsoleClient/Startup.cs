using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarDealer.Core;
using CarDealer.Data;
using CarDealer.Data.Migrations;

namespace CarDealer.ConsoleClient
{
    class Startup
    {
        static void Main(string[] args)
        {
            var migrationStrategy = new MigrateDatabaseToLatestVersion<CarDealerContext, Configuration>();
            Database.SetInitializer(migrationStrategy);
            var context = new CarDealerContext();

            context.Cars.Count();

            var Importer = new Importer();
            Importer.ImportSuppliers();
            Importer.ImportParts();
            Importer.ImportCars();
            Importer.ImportCustomers();
            Importer.ImportSales();

        }
    }
}
