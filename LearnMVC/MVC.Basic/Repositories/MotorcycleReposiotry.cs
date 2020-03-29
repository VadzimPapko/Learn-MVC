using MVC.Basic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Basic.Repositories
{
    public static class MotorcycleRepository
    {
        private static List<Motorcycle> _motorcycles = new List<Motorcycle>() 
        {
            new Motorcycle{Id = 1, Brand = "Honda", Model = "CB600F", MaxSpeed = 270, Value = 600, Price = 3_700 },
            new Motorcycle{Id = 2, Brand = "Suzuki", Model = "CB1000R", MaxSpeed = 350, Value = 1000, Price = 6_000 },
            new Motorcycle{Id = 3, Brand = "Minsk", Model = "X250", MaxSpeed = 100, Value = 250, Price = 1_000 },
            new Motorcycle{Id = 4, Brand = "BMW", Model = "K1200S", MaxSpeed = 350, Value = 1_200, Price = 7_500 }
        };

        public static IEnumerable<Motorcycle> Motorcycles => _motorcycles;

        public static void AddMotorcycle(Motorcycle motorcycle)
        {
            _motorcycles.Add(motorcycle);
        }
    }
}
