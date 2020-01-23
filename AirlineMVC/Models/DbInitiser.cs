using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace AirlineMVC.Models
{
    public class DbInitiser : DropCreateDatabaseIfModelChanges<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            SeedCustomers(context);
            SeedAddresses(context);
        }

        private void SeedCustomers(ApplicationDbContext context)
        {
            var customers = new List<Customer>
            {
                new Customer
                {
                    FirstName ="John",
                    LastName = "Smith",
                    EmailAddress = "john@gmail.com",
                    AddressID = 1,
                    TelephoneNo = "07654 234 123",

                }


            };
        }

        private void SeedAddresses(ApplicationDbContext context)
        {
            throw new NotImplementedException();
        }
    }
    
}