using System.ComponentModel.DataAnnotations;

namespace HotelReservationsManager.Web.Models.ViewModels.Clients
{
    public class ClientsEditViewModel : BaseViewModel
    {
        [Required]
        [MaxLength(50, ErrorMessage = " Oops! First Name can't be more than {0} characters.")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = " Oops! Last Name can't be more than {0} characters.")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = " Oops! Phone number can't be more than {0} characters.")]
        public string Phone { get; set; }

        [Required]
        public bool IsAdult { get; set; }
    }
}
