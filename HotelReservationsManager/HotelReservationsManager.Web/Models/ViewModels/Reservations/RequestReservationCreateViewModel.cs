using HotelReservationsManager.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace HotelReservationsManager.Web.Models.ViewModels.Reservations
{
    public class RequestReservationCreateViewModel
    {
        public string RoomNum { get; set; }
        public virtual Room Room { get; set; }
        public virtual User User { get; set; }
        public List<string> Clients { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Accommodation { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Release { get; set; }

        public bool HasBreakfast { get; set; }
        public bool IsAllInclusive { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = " Oops! Value must be a positive number.")]
        public decimal Price { get; set; }
    }
}
