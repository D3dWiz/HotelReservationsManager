using System.Collections.Generic;

namespace HotelReservationsManager.Web.Models.ViewModels.Clients
{
    public class ClientsAllViewModel
    {
        public PageViewModel Page { get; set; }

        public ICollection<ClientsViewModel> Items { get; set; }
    }
}