using HotelReservationsManager.Web.Models.ViewModels.Reservations;

namespace HotelReservationsManager.Web.Models.ViewModels.Clients
{
    public class ClientsDetailsViewModel : BaseViewModel
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Number { get; set; }
        public string IsAdult { get; set; }
        public ICollection<ReservationsViewModel> Reservations { get; set; }
    }
}
