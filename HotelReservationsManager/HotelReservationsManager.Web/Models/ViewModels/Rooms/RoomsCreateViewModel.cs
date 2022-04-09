using System;
using System.ComponentModel.DataAnnotations;

namespace HotelReservationsManager.Web.Models.ViewModels.Rooms
{
    public class RoomsCreateViewModel
    {
        [Required]
        [Range(1, 5, ErrorMessage = "Negative values or 0 or values ​​above 5 are not accepted")]
        public int Capacity { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public bool IsAvailable { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Negative values are not accepted")]
        public decimal BedPrice { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Negative values are not accepted")]
        public decimal BedPriceChild { get; set; }

        [Required]
        [StringLength(6, MinimumLength = 2, ErrorMessage = "Must be at least 2 characters long. Cannot be more than 6 characters")]
        public string number { get; set; }
    }
}