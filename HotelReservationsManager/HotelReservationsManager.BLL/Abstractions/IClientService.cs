using HotelReservationsManager.DAL.Entities;
using System.Collections.Generic;

namespace HotelReservationsManager.BLL.Abstractions
{
    interface IClientService
    {
        //string FirstName
        //string LastName
        //string PhoneNum
        //string Email
        //bool IsAdult

        bool CreateClient(string firstName, string lastName,
            string phoneNum, string email, bool isAdult);
        bool UpdateClient(int clientId, string firstName, string lastName,
            string phoneNum, string email, bool isAdult);
        List<Client> GetClients();
        Client GetClientById(int clientId);
        bool Remove(int clientId);
    }
}
