namespace AirlineMVC.Migrations
{
    using AirlineMVC.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "AirlineMVC.Models.ApplicationDbContext";
        }

        protected override void Seed(ApplicationDbContext context)
        {
            //SeedAddresses(context);
            //SeedCustomers(context);
        }

        private void SeedAddresses(ApplicationDbContext context)
        {
           
        }

        private void SeedCustomers(ApplicationDbContext context)
        {
            var customers = new List<Customer>
            {
                new Customer
                {
                    CustomerID = 1,
                    EmailAddress = "john@gmail.com",
                    FirstName = "John",
                    LastName = "Smith",
                    TelephoneNo = "07865 234 543",
                    AddressID = 1,
                }
            };

            customers.ForEach(s => context.Customers.Add(s));
            context.SaveChanges();
        }
    }
}
