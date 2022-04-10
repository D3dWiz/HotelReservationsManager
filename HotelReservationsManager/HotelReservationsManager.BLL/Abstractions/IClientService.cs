using HotelReservationsManager.DAL.Entities;

namespace HotelReservationsManager.BLL.Abstractions
{
    public interface IClientService
    {
        bool CreateClient(string firstName, string lastName,
            string phoneNum, string email, bool isAdult);

        bool UpdateClient(int clientId, string firstName, string lastName,
            string phoneNum, string email, bool isAdult);

        List<Client> GetClients();

        Client GetClientById(int clientId);

        bool Remove(int clientId);
    }
}