using System.Collections.Generic;
namespace HotelReservationsManager.Web.Models.ViewModels.Client
{
    public class ClientAllViewModel
    {
        public PageViewModel Page { get; set; }

        public ICollection<ClientViewModel> Items { get; set; }
    }
}
