﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> { 
                new Car{CarId=1, BrandId=1, ColorId=1, ModelYear=2017, DailyPrice=250, Description="Fiat Egea"},
                new Car{CarId=2, BrandId=1, ColorId=2, ModelYear=2014, DailyPrice=200, Description="Fiat Fiorino"},
                new Car{CarId=3, BrandId=2, ColorId=3, ModelYear=2015, DailyPrice=250, Description="Hyundai i20"},
                new Car{CarId=4, BrandId=3, ColorId=1, ModelYear=2019, DailyPrice=230, Description="Renault Clio"},
                new Car{CarId=5, BrandId=4, ColorId=2, ModelYear=2018, DailyPrice=200, Description="Peugeot 301"},

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

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}