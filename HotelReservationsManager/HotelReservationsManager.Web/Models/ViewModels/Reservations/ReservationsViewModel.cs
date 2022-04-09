using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using HotelReservationsManager.DAL.Entities;
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
