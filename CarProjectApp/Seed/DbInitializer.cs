using CarProjectApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarProjectApp.Seed
{
    public class DbInitializer
    {
        public static void Seed(ApplicationDbContext context)
        {
            
            if (!context.Emissions.Any())
            {
                context.Emissions.AddRange(Emissions.Select(c => c.Value));
            }
            context.SaveChanges();
            if (!context.Owners.Any())
            {
                context.Owners.AddRange(Owners.Select(c => c.Value));
            }
            context.SaveChanges();
            if (!context.VinNumbers.Any())
            {
                context.VinNumbers.AddRange(VinNumbers.Select(c => c.Value));
            }
            context.SaveChanges();
            if (!context.Cars.Any())
            {
                context.Cars.AddRange(Cars.Select(c => c.Value));
            }
            context.SaveChanges();
            if (!context.Extras.Any())
            {
                context.Extras.AddRange(Extras.Select(c => c.Value));
            }
            context.SaveChanges();
            
        }
        private static Dictionary<string, Emission> emissions;
        private static Dictionary<string, Emission> Emissions
        {
            get
            {
                if (emissions == null)
                {
                    var EmissionList = new Emission[]
                    {
                    new Emission {EuroStandart = "Euro 1"},
                    new Emission {EuroStandart = "Euro 2"},
                    new Emission {EuroStandart = "Euro 3"},
                    new Emission {EuroStandart = "Euro 4"},
                    new Emission {EuroStandart = "Euro 5"},
                    new Emission {EuroStandart = "Euro 6"},
                    new Emission {EuroStandart = "Without Euro standart"},
                    };
                    emissions = new Dictionary<string, Emission>();
                    foreach (Emission emission in EmissionList)
                    {
                        emissions.Add(emission.EuroStandart, emission);
                    }
                }
                return emissions;

            }
        }
        private static Dictionary<string, Owner> owners;
        private static Dictionary<string, Owner> Owners
        {
            get
            {
                if (owners == null)
                {
                    var OwnerList = new Owner[]
                    {
                    new Owner {Name="Александър Капра", Egn="9907291484"},
                    new Owner {Name="Иван Благоев", Egn="7305151486"},
                    new Owner {Name="Ренета Ивелинова", Egn="9905161482"},

                    };
                    owners = new Dictionary<string, Owner>();
                    foreach (Owner owner in OwnerList)
                    {
                        owners.Add(owner.Name, owner);
                    }
                }
                return owners;

            }
        }
        private static Dictionary<string, Extra> extras;
        private static Dictionary<string, Extra> Extras
        {
            get
            {
                if (extras == null)
                {
                    var ExtraList = new Extra[]
                    {
                    new Extra {Name = "A/C", Description = "Air Conditioning"},
                    new Extra {Name = "El.Pack", Description = "Electrical mirrors, Electric windows, Heated seats"},
                    new Extra {Name = "Light Alloy Wheels", Description = "Light Alloy Wheels made from Alumiminum"}
                    };
                    extras = new Dictionary<string, Extra>();
                    foreach (Extra extra in ExtraList)
                    {
                        extras.Add(extra.Name, extra);
                    }
                }
                return extras;

            }
        }
        private static Dictionary<string, VinNumber> vinnumbers;
        private static Dictionary<string, VinNumber> VinNumbers
        {
            get
            {
                if (vinnumbers == null)
                {
                    var VinNumberList = new VinNumber[]
                    {
                    new VinNumber {Vin = "WVWZZZ3BZWE689725"},
                    new VinNumber {Vin = "WVGZZZ3ZBEW869785"},
                    new VinNumber {Vin = "ZHBKKK4OURW989986"}
                    
                    };
                    vinnumbers = new Dictionary<string, VinNumber>();
                    foreach (VinNumber vinnumber in VinNumberList)
                    {
                        vinnumbers.Add(vinnumber.Vin, vinnumber);
                    }
                }
                return vinnumbers;

            }
        }


        private static Dictionary<string, Car> cars;
         private static Dictionary<string, Car> Cars
         {
             get
             {
                 if (cars == null)
                 {
                    var CarList = new Car[]
                    {
                     new Car {
                         Brand = "VW", Model = "Polo",
                         ManifactoryDate = new DateTime(2001, 3,5),
                         CubicCapacity = 1422,
                         Horsepower = 75,
                         RegNumber = "ВТ 7856 КР",
                         FuelType = "Diesel",
                         BodyType = "Hatchback",
                         EmissionId = 1,
                         OwnerId = 1,
                         VinNumberId = 1,
                         
                         
                     },
                        new Car {
                         Brand = "VW", Model = "Golf",
                         ManifactoryDate = new DateTime(2002, 4,6),
                         CubicCapacity = 1560,
                         Horsepower = 100,
                         RegNumber = "ВТ 8565 КР",
                         FuelType = "Gasoline",
                         BodyType = "Hatchback",
                         EmissionId = 2,
                         OwnerId = 2,
                         VinNumberId = 2
                     },
                     new Car {
                         Brand = "VW", Model = "Lupo",
                         ManifactoryDate = new DateTime(2004, 2,4),
                         CubicCapacity = 1422,
                         Horsepower = 75,
                         RegNumber = "ВТ 9789 КР",
                         FuelType = "Diesel",
                         BodyType = "Hatchback",
                         EmissionId = 3,
                         OwnerId = 3,
                         VinNumberId = 3
                     }
                     };
                     cars = new Dictionary<string, Car>();
                     foreach (Car car in CarList)
                     {
                         cars.Add(car.RegNumber, car);
                     }
                 }
                 return cars;

             }
         }
    }
}
