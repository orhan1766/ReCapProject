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
            Car car1 = new Car { BrandId = 1, ColorId = 5, CarName = "FORD FOCUS", DailyPrice = 120, ModelYear = 2019, Description = "Düz Vites" };
            Brand brand1 = new Brand { Name = "FORD" };
            Color color1 = new Color { Name = "Beyaz" };

            Car car2 = new Car { BrandId = 2, ColorId = 4, CarName = "RENAULT MEGANE", DailyPrice = 150, ModelYear = 2020, Description = "Otomatik Vites" };
            Brand brand2 = new Brand { Name = "RENAULT" };
            Color color2 = new Color { Name = "Gri" };

            Car car3 = new Car { BrandId = 3, ColorId = 3, CarName = "TOYOTA COROLLA", DailyPrice = 100, ModelYear = 2018, Description = "Düz Vites" };
            Brand brand3 = new Brand { Name = "TOYOTA" };
            Color color3 = new Color { Name = "Mavi" };

            Car car4 = new Car { BrandId = 1, ColorId = 4, CarName = "FORD FOCUS", DailyPrice = 140, ModelYear = 2019, Description = "Otomatik Vites" };
            Brand brand4 = new Brand { Name = "FORD" };
            Color color4 = new Color { Name = "Gri" };

            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());

            //carManager.Add(car1);
            //brandManager.Add(brand1);
            //colorManager.Add(color1);

            //carManager.Add(car2);
            //brandManager.Add(brand2);
            //colorManager.Add(color2);

            //carManager.Add(car3);
            //brandManager.Add(brand3);
            //colorManager.Add(color3);

            //carManager.Add(car4);
            //brandManager.Add(brand4);
            //colorManager.Add(color4);

            var result1 = carManager.GetAll();

            foreach (var car in result1.Data)
            {
                Console.WriteLine(car.CarName+" / "+car.Description);
            }

            //carManager.Delete(new Car { Id=1});

            var result2 = carManager.GetCarDetail();

            foreach (var detail in result2.Data)
            {
                Console.WriteLine(detail.CarName + " / " +detail.BrandName + " / " +detail.ColorName + " / " +detail.DailyPrice);
            }
        }
    }
}
