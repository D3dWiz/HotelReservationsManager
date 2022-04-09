namespace HotelReservationsManager.DAL.Entities
{
    public class Client : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNum { get; set; }
        public string Email { get; set; }
        public bool IsAdult { get; set; } // Is over 18 years old
    }
}