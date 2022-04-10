using HotelReservationsManager.DAL.Entities;
using System.ComponentModel.DataAnnotations;

namespace HotelReservationsManager.Web.Models.ViewModels.Reservations
{
    public class ReservationsViewModel : BaseViewModel
    {
        public string RoomNum { get; set; }
        public string UserName { get; set; }
        public virtual ICollection<Client> Clients { get; set; }

        [DataType(DataType.Date)]
        public DateTime Accommodation { get; set; }

        [DataType(DataType.Date)]
        public DateTime Release { get; set; }
        public bool HasBreakfast { get; set; }
        public bool IsAllInclusive { get; set; }
        public decimal FinalPrice { get; set; }
    }
}
