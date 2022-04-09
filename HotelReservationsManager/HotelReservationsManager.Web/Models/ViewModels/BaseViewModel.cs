using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HotelReservationsManager.Web.Models.ViewModels
{
    public class BaseViewModel
    {
        [Key]
        [ScaffoldColumn(false)]
        public int Id { get; set; }
        [ScaffoldColumn(false)]
        [DisplayName("Created")]
        public DateTime CreatedAt { get; set; }
        [ScaffoldColumn(false)]
        [DisplayName("Modified")]
        public DateTime ModifiedAt { get; set; }
    }
}