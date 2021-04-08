using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleUI
{
    class Program
    {
        //static CarManager carManager = new CarManager(new InMemoryCarDal());

        #region dummybrands codes
        //var brands = new List<Brand> {
        //    new Brand {Id =1, BrandName="Maserati" },
        //    new Brand {Id =2, BrandName="Audi" },
        //    new Brand {Id =3, BrandName="Benz" }
        //}; 
        #endregion

        static void Main(string[] args)
        {

            CarManager carManager = new CarManager(new EfCarDal());
            var cars = carManager.GetCarDetails();
            if (cars.Success==true)
            {
                foreach (var car in cars.Data)
                {
                    Console.WriteLine(car.CarName + " / " + car.BrandName + " / " + car.ColorName + " / " + car.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(cars.Message);
            }
            

            Console.ReadKey();
        }
    }
}
