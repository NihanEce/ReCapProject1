using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal:ICarDal
    {
        List<Car> _car;
        
        public InMemoryCarDal()
        {
            _car = new List<Car> 
            {
                new Car {Id=1,ColorId=2,BrandId=7,DailyPrice=100000,Description="Renault",ModelYear=2020},
                new Car {Id=2,ColorId=3,BrandId=8,DailyPrice=200000,Description="Hundai",ModelYear=2021},
                new Car {Id=3,ColorId=4,BrandId=9,DailyPrice=300000,Description="Mercedes",ModelYear=2019},
                new Car {Id=4,ColorId=5,BrandId=10,DailyPrice=400000,Description="Audi",ModelYear=2018},
                new Car {Id=5,ColorId=6,BrandId=11,DailyPrice=500000,Description="Jeep",ModelYear=2017},


            };
        }


        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _car.SingleOrDefault(c => c.Id == car.Id);
            _car.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetById(int id)
        {
            return _car.Where(c => c.Id == id).ToList();
        }

        public List<Car> GetById()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _car.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
           
        }
    }
}
