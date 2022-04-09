using System.Collections.Generic;
namespace HotelReservationsManager.Web.Models.ViewModels.Users
{
    public class UsersAllViewModel
    {
        public PageViewModel Page { get; set; }

        public ICollection<UsersViewModel> Items { get; set; }
    }
}