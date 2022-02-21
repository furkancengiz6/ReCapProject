using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> { 
            new Car{ Id=1,BrandId=10,ColorId=5,ModelYear="2015",DailyPrice=65000,Description="Güzel Araba"},
            new Car{ Id=2,BrandId=11,ColorId=5,ModelYear="2020",DailyPrice=80000,Description="Çok Güzel Araba"},
            new Car{ Id=3,BrandId=12,ColorId=6,ModelYear="2021",DailyPrice=99000,Description="Efsane Araba"},
            new Car{ Id=4,BrandId=13,ColorId=7,ModelYear="2019",DailyPrice=100000,Description="Süper Araba"},
            new Car{ Id=5,BrandId=14,ColorId=7,ModelYear="2022",DailyPrice=6000000,Description="A   "},
            };
        }
        public void Add(Car car)
        {
           _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.ModelYear = car.ModelYear;  
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.Description = car.Description;  
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ColorId = car.ColorId;

        }
    }
}
