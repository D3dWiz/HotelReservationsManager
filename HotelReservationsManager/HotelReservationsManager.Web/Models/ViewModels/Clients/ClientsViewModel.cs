namespace HotelReservationsManager.Web.Models.ViewModels.Clients
{
    public class ClientsViewModel : BaseViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNum { get; set; }
        public string Email { get; set; }
        public bool IsAdult { get; set; }
    }
}