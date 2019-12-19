using CoreMVCTest2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMVCTest2.Data
{
    public static class DbInitialiser
    {
        public static void Initialise(ApplicationDbContext context)
        {
            //InitialiseAddresses(context);

            // Look for any Addresss.
            if (context.Address.Any())
            {
                return;   // DB has been seeded
            }

           // var Addresss = new Address[]
            //{
            //new Address{HouseNumber="Earthope Hall",Street="Quarry Street",Town="Milverton", County="Nottinghamshire", PostCode=" "},
            //new Address{HouseNumber="78",Street="Binswood Lane",Town= "Lillington"County = "Berkshire", PostCode = " "},
            //new Address{HouseNumber="38",Street="Trinity Hill",Town= "Pinley Green"County = "Cornwall", PostCode = " "},
            //new Address{HouseNumber="214",Street="Warwick New Road",Town= "Dodwell"County = "Hampshire", PostCode = " "},
            //new Address{HouseNumber="8",Street="Leam Road",Town= "Warwick"County = "Devon", PostCode = " "},
            //new Address{HouseNumber="Church Cottage",Street="Hatton",Town="Radford Semele"County = "Dorset", PostCode = " "},
            //new Address{HouseNumber="Sandy Lodge",Street="Rugby Road",Town= "Claverdon"County = "Somerset", PostCode = " "},
            //new Address{HouseNumber="150",Street="Guys Cliffe Avenue",Town= "Harbury"County = "Kent", PostCode = " "}
            //new Address{HouseNumber="Wilhelmina Cottage",Street="Heath Terrence",Town= "Norton Lindsey"County = "Hertfordshire", PostCode = " " },
            //new Address{HouseNumber="62",Street="Grove Street",Town= "Blackdown"County = "Essex", PostCode = " "}
            //};
            foreach (Address s in Addresses)
            {
                context.Addresss.Add(s);
            }
            context.SaveChanges();

            var counties = new County[]
            {
            new Counties{County=1050,Title="Chemistry",Credits=3},
            new Counties{County=4022,Title="Microeconomics",Credits=3},
            new Counties{County=4041,Title="Macroeconomics",Credits=3},
            new Counties{County=1045,Title="Calculus",Credits=4},
            new Counties{County=3141,Title="Trigonometry",Credits=4},
            new Counties{County=2021,Title="Composition",Credits=3},
            new Counties{County=2042,Title="Literature",Credits=4}
            };
            foreach (County c in counties)
            {
                context.County.Add(c);
            }
            context.SaveChanges();

            var enrollments = new Enrollment[]
            {
            new Enrollment{AddressID=1,CourseID=1050,Grade=Grade.A},
            new Enrollment{AddressID=1,CourseID=4022,Grade=Grade.C},
            new Enrollment{AddressID=1,CourseID=4041,Grade=Grade.B},
            new Enrollment{AddressID=2,CourseID=1045,Grade=Grade.B},
            new Enrollment{AddressID=2,CourseID=3141,Grade=Grade.F},
            new Enrollment{AddressID=2,CourseID=2021,Grade=Grade.F},
            new Enrollment{AddressID=3,CourseID=1050},
            new Enrollment{AddressID=4,CourseID=1050},
            new Enrollment{AddressID=4,CourseID=4022,Grade=Grade.F},
            new Enrollment{AddressID=5,CourseID=4041,Grade=Grade.C},
            new Enrollment{AddressID=6,CourseID=1045},
            new Enrollment{AddressID=7,CourseID=3141,Grade=Grade.A},
            };
            foreach (Enrollment e in enrollments)
            {
                context.Enrollments.Add(e);
            }
            context.SaveChanges();
        }

        private static void InitialiseAddresses(ApplicationDbContext context)
        {
            if(context.Address.Any())
            {
                return;
            }

            var addresses = new Address[]
            {
                new Address
                {
                }
            };
        }
    }
}
