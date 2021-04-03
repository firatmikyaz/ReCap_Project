using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> 
            { 
                new Car{CarId=1,BrandId=1,ColorId=1,ModelYear=2020,DailyPrice=200,Description="Audi A3 sport model"},
                new Car{CarId=2,BrandId=2,ColorId=2,ModelYear=2019,DailyPrice=50,Description="Fiat 500 sport model"},
                new Car{CarId=3,BrandId=3,ColorId=3,ModelYear=2021,DailyPrice=150,Description="VW Amarok 4X4"},
                new Car{CarId=4,BrandId=3,ColorId=2,ModelYear=2018,DailyPrice=120,Description="VW Golf sport model"},
                new Car{CarId=5,BrandId=4,ColorId=1,ModelYear=2021,DailyPrice=180,Description="Mercedes S350 model"},
                new Car{CarId=6,BrandId=4,ColorId=4,ModelYear=2017,DailyPrice=150,Description="A1 sport model"},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int BrandId)
        {
            return _cars.Where(c => c.BrandId == BrandId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
