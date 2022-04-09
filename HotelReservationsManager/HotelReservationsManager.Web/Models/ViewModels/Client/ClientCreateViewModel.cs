using System.ComponentModel.DataAnnotations;
namespace HotelReservationsManager.Web.Models.ViewModels.Client
{
    public class ClientCreateViewModel
    {
        [Required]
        [MaxLength(50, ErrorMessage = " Oops! First name can't be more than 50 characters.")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = " Oops! Last name can't be more than 50 characters.")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = " {0} must be {2}")]
        public string PhoneNumber { get; set; }

        [Required]
        public bool IsAdult { get; set; }
    }
}
