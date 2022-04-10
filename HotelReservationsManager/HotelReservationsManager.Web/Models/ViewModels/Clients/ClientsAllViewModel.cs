namespace HotelReservationsManager.Web.Models.ViewModels.Clients
{
    public class ClientsAllViewModel : BaseViewModel
    {
        public PageViewModel Page { get; set; }

        public ICollection<ClientsViewModel> Items { get; set; }
    }
}
