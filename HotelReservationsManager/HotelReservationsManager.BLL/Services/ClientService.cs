using HotelReservationsManager.BLL.Abstractions;
using HotelReservationsManager.DAL.Abstractions;
using HotelReservationsManager.DAL.Entities;

namespace HotelReservationsManager.BLL.Services
{
    public class ClientService : IClientService
    {
        private readonly IRepository<Client> _clientRepository;

        public ClientService(IRepository<Client> clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public bool CreateClient(string firstName, string lastName, string phone, string email, bool isAdult)
        {
            var client = new Client()
            {
                FirstName = firstName,
                LastName = lastName,
                Phone = phone,
                Email = email,
                IsAdult = isAdult
            };
            return _clientRepository.Create(client);
        }

        public Client GetClientById(int clientId)
        {
            return _clientRepository.GetById(clientId);
        }

        public List<Client> GetClients()
        {
            return _clientRepository.GetAll();
        }

        public bool Remove(int clientId)
        {
            return _clientRepository.RemoveById(clientId);
        }

        public bool UpdateClient(int clientId, string firstName, string lastName, string phone, string email, bool isAdult)
        {
            var client = _clientRepository.GetById(clientId);
            client.FirstName = firstName;
            client.LastName = lastName;
            client.Phone = phone;
            client.Email = email;
            client.IsAdult = isAdult;

            return _clientRepository.Update(client);
        }
    }
}