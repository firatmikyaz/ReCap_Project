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

        static CarManager carManager = new CarManager(new EfCarDal());
        #region dummybrands codes
        //var brands = new List<Brand> {
        //    new Brand {Id =1, BrandName="Maserati" },
        //    new Brand {Id =2, BrandName="Audi" },
        //    new Brand {Id =3, BrandName="Benz" }
        //}; 
        #endregion

        static void Main(string[] args)
        {
            //GetAllTest();
            CarManager carManager = new CarManager(new EfCarDal());

            var cars = carManager.GetAll();
            foreach (var car in cars)
            {
                Console.WriteLine(car.CarName);
            }

            Console.ReadKey();


        }

        private static void GetAllTest()
        {
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.ModelYear + " - " + car.Description);

            }
            Console.ReadKey();
        }
    }
}
