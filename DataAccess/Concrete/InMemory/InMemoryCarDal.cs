using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;




namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1,BrandId=2,ColorId=3,DailyPrice=54500,ModelYear="2005",Description="Opel"},
                new Car{Id=2,BrandId=2,ColorId=4,DailyPrice=92500,ModelYear="2011",Description="Opel "},
                new Car{Id=3,BrandId=1,ColorId=1,DailyPrice=113000,ModelYear="2016",Description="Honda"},
                new Car{Id=4,BrandId=3,ColorId=2,DailyPrice=73750,ModelYear="2014",Description="Mercedes"},
                new Car{Id=5,BrandId=3,ColorId=5,DailyPrice=84750,ModelYear="2016",Description="Mercedes"},
            };
        }


        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p=> p.Id==car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(p=>p.Id==Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpgrade = _cars.SingleOrDefault(p=> p.Id==car.Id);
            carToUpgrade.BrandId = car.BrandId;
            carToUpgrade.ColorId = car.ColorId;
            carToUpgrade.ModelYear = car.ModelYear;
            carToUpgrade.DailyPrice = car.DailyPrice;
            carToUpgrade.Description = car.Description;
        }
    }
}
