using System.ComponentModel.DataAnnotations;

namespace HotelReservationsManager.Web.Models.ViewModels.Clients
{
    public class ClientsCreateViewModel : BaseViewModel
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
        [StringLength(10, ErrorMessage = " Oops! Phone number can't be more than {0} characters.")]
        public string PhoneNum { get; set; }

        [Required]
        public bool IsAdult { get; set; }
    }
}