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
            var addresses = new List<Address>
            {
                new Address
                {
                    AddressID = 1,
                    HouseNumber = "142",
                    Street = "Arnos Park",
                    Town = "Broadfield",
                    County = Counties.Bedfordshire,
                    PostCode = "BO5 1EH",
                    CustomerID = 1,
                },
                new Address
                {
                    AddressID = 2,
                    HouseNumber = "92B",
                    Street = "Cadmore Way",
                    Town = "Rosendale",
                    County = Counties.Sussex,
                    PostCode = "RH10 5NH",
                    CustomerID = 2,
                },
                new Address
                {
                    AddressID = 3,
                    HouseNumber = "83",
                    Street = "Pembroke hart Street",
                    Town = "North Ham",
                    County = Counties.Wiltshire,
                    PostCode = "RH11 7HM",
                    CustomerID = 3,
                },
                new Address
                {
                    AddressID = 4,
                    HouseNumber = "7416",
                    Street = "Gooch Street",
                    Town = "Lockley Heath",
                    County = Counties.Essex,
                    PostCode = "BO2 8SE",
                    CustomerID = 4,
                },                
                new Address
                {
                    AddressID = 5,
                    HouseNumber = "266",
                    Street = "Chad Leawood Close",
                    Town = "New Dudley Oak",
                    County = Counties.Shropshire,
                    PostCode = "ST17 7SW",
                    CustomerID = 5,
                },
                new Address
                {
                    AddressID = 6,
                    HouseNumber = "11",
                    Street = "South Wickham Avenue",
                    Town = "Hafford Town",
                    County = Counties.Staffordshire,
                    PostCode = "BF22 6AR",
                    CustomerID = 6,
                },                
                new Address
                {
                    AddressID = 7,
                    HouseNumber = "32",
                    Street = "Wilfred Gardens",
                    Town = "Barrow Green",
                    County = Counties.Cumbria,
                    PostCode = "BF22 3PO",
                    CustomerID = 7,
                },
                new Address
                {
                    AddressID = 8,
                    HouseNumber = "205",
                    Street = "Norton Avenue",
                    Town = "Cotteridge End",
                    County = Counties.Bedfordshire,
                    PostCode = "MK31 4LI",
                    CustomerID = 8,
                },                
                new Address
                {
                    AddressID = 9,
                    HouseNumber = "69A",
                    Street = "Eatfields",
                    Town = "Helstree Vale",
                    County = Counties.Middlesex,
                    PostCode = "BO3 3NU",
                    CustomerID = 9,
                },
                new Address
                {
                    AddressID = 10,
                    HouseNumber = "590",
                    Street = "Warren Street West",
                    Town = "Kidsgrove",
                    County = Counties.Buckinghamshire,
                    PostCode = "HP25 5DF",
                    CustomerID = 10,
                }
            };
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
                },
                new Customer
                {
                    CustomerID = 2,
                    EmailAddress = "dolce@gmail.com",
                    FirstName = "Dolce",
                    LastName = "Mayfair",
                    TelephoneNo = "07883 151 101",
                    AddressID = 2,
                } ,
                new Customer
                {
                    CustomerID = 3,
                    EmailAddress = "storm@gmail.com",
                    FirstName = "Storm",
                    LastName = "Fearon-Cleary",
                    TelephoneNo = "07874 524 640",
                    AddressID = 3,
                },
                new Customer
                {
                    CustomerID = 4,
                    EmailAddress = "george@gmail.com",
                    FirstName = "George",
                    LastName = "Lenton",
                    TelephoneNo = "07460 945 680",
                    AddressID = 4,
                },
                new Customer
                {
                    CustomerID = 5,
                    EmailAddress = "regan@gmail.com",
                    FirstName = "Regan",
                    LastName = "Harrison",
                    TelephoneNo = "07523 897 096",
                    AddressID = 5,
                },
                new Customer
                {
                    CustomerID = 6,
                    EmailAddress = "conrad@gmail.com",
                    FirstName = "Conrad",
                    LastName = "Smithies",
                    TelephoneNo = "07407 897 587",
                    AddressID = 6,
                },
                new Customer
                {
                    CustomerID = 7,
                    EmailAddress = "tatiana@gmail.com",
                    FirstName = "Tatiana",
                    LastName = "Francesco",
                    TelephoneNo = "07997 453 465",
                    AddressID = 7,
                } ,
                new Customer
                {
                    CustomerID = 8,
                    EmailAddress = "katherine@gmail.com",
                    FirstName = "Katherine",
                    LastName = "Cathcart",
                    TelephoneNo = "07857 563 423",
                    AddressID = 8,
                },
                new Customer
                {
                    CustomerID = 9,
                    EmailAddress = "toni@gmail.com",
                    FirstName = "Toni",
                    LastName = "Daniel-Connock",
                    TelephoneNo = "07716 905 976",
                    AddressID = 9,
                },
                new Customer
                {
                    CustomerID = 10,
                    EmailAddress = "sophie@gmail.com",
                    FirstName = "Sophie",
                    LastName = "Taylor",
                    TelephoneNo = "07503 477 647",
                    AddressID = 10,
                },
            };

            customers.ForEach(s => context.Customers.Add(s));
            context.SaveChanges();
        }
    }
}
