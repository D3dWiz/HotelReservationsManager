using System;
using System.ComponentModel.DataAnnotations;

namespace HotelReservationsManager.Web.Models.ViewModels.Client
{
    public class UserViewlModel
    {
        public string Id { get; set; }
        public string Username { get; set; }
        public string FullName { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = " The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 5)]
        public string EGN { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = " The {0} must be {2}")]
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        [DataType(DataType.Date)]
        public DateTime AppointmentDate { get; set; }
        public string IsActive { get; set; }
        public string DateOfDismissal { get; set; }
    }
}
