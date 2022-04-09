using HotelReservationsManager.DAL.Entities;
using System;
using System.Collections.Generic;

namespace HotelReservationsManager.BLL.Abstractions
{
    public interface IUserService
    {
        //string Username
        //string Password
        //string FirstName
        //string SecondName
        //string LastName
        //int IdentificationNumber
        //string Phone
        //string Email
        //DateTime Appointment
        //bool IsActive
        //DateTime? Dismissal

        bool CreateUser(string username, string password, string firstName,
            string secondName, string lastName, int identificationNumber,
            string phoneNum, string email, DateTime appointment, bool isActive);

        bool UpdateUser(int userId, string username, string password, string firstName,
            string secondName, string lastName, int identificationNumber,
            string phoneNum, string email, DateTime appointment, bool isActive);

        List<User> GetUsers();

        User GetUserById(int userId);

        bool Remove(int userId);

        bool FiredUser(int userId);
    }
}