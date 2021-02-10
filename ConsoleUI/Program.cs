﻿using Business.Concrete;
using DataAccess.Abstract;
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
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var cars in carManager.GetCarDetails())
            {
                Console.WriteLine("Marka : "+cars.BrandName+" "+cars.Description+" "+cars.ColorName+" => "+cars.DailyPrice);
            }

           
        }
    }
}
