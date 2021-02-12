using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car { BrandId = 1, ColorId = 5, DailyPrice = 100, ModelYear = 2019, Description = "Focus" };
            Car car2 = new Car { BrandId = 1, ColorId = 4, DailyPrice = 150, ModelYear = 2019, Description = "Passat" };
            Car car3 = new Car { BrandId = 3, ColorId = 3, DailyPrice = 120, ModelYear = 2019, Description = "Jetta" };

            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetCarsByColorId(5))
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}
