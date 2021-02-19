using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Id + " " + car.ModelYear + " " + car.DailyPrice + " " + car.Description);
            }
            Console.WriteLine("-----------");
            foreach (var car in carManager.GetById(3))
            {
                Console.WriteLine(car.Id + " " + car.ModelYear + " " + car.DailyPrice + " " + car.Description);
            }
            Console.WriteLine("-----------");

            InMemoryCarDal inMemoryCarDal = new InMemoryCarDal();
            inMemoryCarDal.Add(new Car {
                Id=6,
                BrandId=4,
                ColorId=3,
                DailyPrice=94500,
                ModelYear="2009",
                Description="Nissan" });
           

            inMemoryCarDal.Update(new Car
            {
                Id = 5,
                BrandId = 4,
                ColorId = 3,
                DailyPrice = 94500,
                ModelYear = "2009",
                Description = "Nissan"
            });

        }
    }
}
