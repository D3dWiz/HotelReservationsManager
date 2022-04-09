using System.Collections.Generic;

namespace HotelReservationsManager.Web.Models.ViewModels.Rooms
{
    public class RoomsAllViewModel
    {
        public PageViewModel Page { get; set; }

        public ICollection<RoomsViewModel> Items { get; set; }
    }
}