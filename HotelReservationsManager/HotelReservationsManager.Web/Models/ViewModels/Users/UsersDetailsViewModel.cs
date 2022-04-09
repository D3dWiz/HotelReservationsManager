using System;
using System.ComponentModel.DataAnnotations;

namespace HotelReservationsManager.Web.Models.ViewModels.Users
{
    public class UsersDetailsViewModel : BaseViewModel
    {
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = " The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 5)]
        public string IdentificationNumber { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = " The {0} must be {2}")]
        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        [DataType(DataType.Date)]
        public DateTime Appointment { get; set; }

        public string IsActive { get; set; }
        public string Dismissal { get; set; }
    }
}