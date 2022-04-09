using System.Collections.Generic;
namespace HotelReservationsManager.Web.Models.ViewModels.Client
{
    public class ClientDetailsViewModel
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Number { get; set; }
        public string IsAdult { get; set; }
        public ICollection<ReservationsViewModel> Reservations { get; set; }
    }
}
