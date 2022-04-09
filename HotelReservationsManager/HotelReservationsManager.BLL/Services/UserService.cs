using HotelReservationsManager.BLL.Abstractions;
using HotelReservationsManager.DAL.Abstractions;
using HotelReservationsManager.DAL.Entities;
using System;
using System.Collections.Generic;

namespace HotelReservationsManager.BLL.Services
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> _userRepository;

        public UserService(IRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }

        public bool CreateUser(string username, string password, string firstName,
            string middleName, string lastName, int identificationNumber,
            string phoneNum, string email, DateTime appointment, bool isActive)
        {
            var user = new User()
            {
                Username = username,
                Password = password,
                FirstName = firstName,
                MiddleName = middleName,
                LastName = lastName,
                IdentificationNumber = identificationNumber,
                Phone = phoneNum,
                Email = email,
                Appointment = appointment,
                IsActive = isActive
            };
            return _userRepository.Create(user);
        }

        public bool FiredUser(int userId)
        {
            var user = _userRepository.GetById(userId);
            user.Dismissal = DateTime.Now;
            return _userRepository.Update(user);
        }

        public User GetUserById(int userId)
        {
            return _userRepository.GetById(userId);
        }

        public List<User> GetUsers()
        {
            return _userRepository.GetAll();
        }

        public bool Remove(int userId)
        {
            return _userRepository.RemoveById(userId);
        }

        public bool UpdateUser(int userId, string username, string password,
            string firstName, string middleName, string lastName,
            int identificationNumber, string phoneNum, string email, DateTime appointment, bool isActive)
        {
            var user = _userRepository.GetById(userId);
            user.Username = username;
            user.Password = password;
            user.FirstName = firstName;
            user.MiddleName = middleName;
            user.LastName = lastName;
            user.IdentificationNumber = identificationNumber;
            user.Phone = phoneNum;
            user.Email = email;
            user.Appointment = appointment;
            user.IsActive = isActive;

            return _userRepository.Update(user);
        }
    }
}