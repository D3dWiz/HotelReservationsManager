using System;

namespace HotelReservationsManager.DAL.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public int IdentificationNumber { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime Appointment { get; set; }
        public bool IsActive { get; set; }
        public DateTime? Dismissal { get; set; }
    }
}