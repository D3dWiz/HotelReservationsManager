using HotelReservationsManager.DAL.Entities;

namespace HotelReservationsManager.BLL.Abstractions
{
    public interface IUserService
    {
        bool CreateUser(string id, string userName, string password, string firstName,
            string middleName, string lastName, string idn, string phone, string email,
            DateTime appointmentDate, bool isActive, bool isAdmin);

        bool UpdateUser(string id, int userId, string userName, string password, string firstName,
            string middleName, string lastName, string idn, string phone, string email,
            DateTime appointmentDate, bool isActive, bool isAdmin);

        List<User> GetUsers();

        User GetUserById(int userId);

        bool Remove(int userId);

        bool FiredUser(int userId);
    }
}