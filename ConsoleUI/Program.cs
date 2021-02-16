using Business.Concrete;
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
            var result1 = carManager.GetCarDetails();
            foreach (var cars in result1.Data)
            {
                Console.WriteLine("Marka : " + cars.BrandName + " " + cars.Description + " " + cars.ColorName + " => " + cars.DailyPrice);
            }

            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            var result = rentalManager.GetRentalDetailsDto();
            foreach (var rent in result.Data)
            {
                Console.WriteLine(rent.Description + " " + rent.CustomerName + " " + rent.ReturnDate);
            }

            Rental rental = new Rental { CarId = 5, CustomerId = 2, RentDate = DateTime.Now, ReturnDate = null };
            Console.WriteLine(rentalManager.Add(rental).Message);

            

            //UserManager userManager = new UserManager(new EfUserDal());
            //userManager.Add(new User { FirstName = "İbrahim", LastName = "TÜRK", Email = "ibrahimtrk", Password = "1122" });
            //foreach (var user in userManager.GetAll().Data)
            //{
            //    Console.WriteLine(user.FirstName);
            //}

            //ColorManager colorManager = new ColorManager(new EfColorDal());
            //colorManager.Add(new Color { ColorName = "mavi" });
            //foreach (var color in colorManager.GetAll())
            //{
            //    Console.WriteLine(color.ColorName);
            //}



        }
    }
}
