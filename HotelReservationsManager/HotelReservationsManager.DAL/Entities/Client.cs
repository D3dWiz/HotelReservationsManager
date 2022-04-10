namespace HotelReservationsManager.DAL.Entities
{
    public class Client : BaseEntity
    {
        public Client()
        {
        }

        public Client(Client client)
        {
            Id = client.Id;
            FirstName = client.FirstName;
            LastName = client.LastName;
            Phone = client.Phone;
            Email = client.Email;
            IsAdult = client.IsAdult;
            ClientReservationHistory = client.ClientReservationHistory;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public bool IsAdult { get; set; }
        public virtual ICollection<ClientReservationHistory> ClientReservationHistory { get; set; }
    }
}