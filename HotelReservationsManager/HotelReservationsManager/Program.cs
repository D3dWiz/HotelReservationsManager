using HotelReservationsManager.BLL.Services;
using HotelReservationsManager.DAL.Abstractions;
using HotelReservationsManager.DAL.Data;
using HotelReservationsManager.DAL.Entities;
using HotelReservationsManager.DAL.Repositories;
using System;

namespace HotelReservationsManager
{
    class Program
    {
        static void Main(string[] args)
        {
            HotelDbContext context = new HotelDbContext();
            IRepository<User> userRepo = new Repository<User>(context);
            IRepository<Client> clientRepo = new Repository<Client>(context);

            UserService userService = new UserService(userRepo);
            foreach (var item in userService.GetUsers())
            {
                Console.WriteLine(item.FirstName, item.LastName);
            }
        }
    }
}
