using HotelReservationsManager.BLL.Abstractions;
using HotelReservationsManager.DAL.Abstractions;
using HotelReservationsManager.DAL.Entities;

namespace HotelReservationsManager.BLL.Services
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> _userRepository;

        public UserService(IRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }

        public bool CreateUser(string id, string userName, string password, string firstName,
            string middleName, string lastName, string idn, string phone, string email,
            DateTime appointmentDate, bool isActive, bool isAdmin)
        {
            var user = new User()
            {
                Id = id,
                UserName = userName,
                Password = password,
                FirstName = firstName,
                MiddleName = middleName,
                LastName = lastName,
                IDN = idn,
                Phone = phone,
                Email = email,
                AppointmentDate = appointmentDate,
                IsActive = isActive
            };
            return _userRepository.Create(user);
        }

        public bool FiredUser(int userId)
        {
            var user = _userRepository.GetById(userId);
            user.DismissalDate = DateTime.Now;
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

        public bool UpdateUser(string id, int userId, string userName, string password, string firstName,
            string middleName, string lastName, string idn, string phone, string email,
            DateTime appointmentDate, bool isActive, bool isAdmin)
        {
            var user = _userRepository.GetById(userId);
            user.UserName = userName;
            user.Password = password;
            user.FirstName = firstName;
            user.MiddleName = middleName;
            user.LastName = lastName;
            user.IDN = idn;
            user.Phone = phone;
            user.Email = email;
            user.AppointmentDate = appointmentDate;
            user.IsActive = isActive;

            return _userRepository.Update(user);
        }
    }
}