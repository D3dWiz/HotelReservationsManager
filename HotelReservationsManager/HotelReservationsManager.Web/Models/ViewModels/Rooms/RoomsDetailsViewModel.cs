namespace HotelReservationsManager.Web.Models.ViewModels.Rooms
{
    public class RoomsDetailsViewModel : BaseViewModel
    {
        public int Capacity { get; set; }
        public string type { get; set; }
        public string IsAvalable { get; set; }
        public decimal BedPrice { get; set; }
        public decimal BedPriceChild { get; set; }
        public string Number { get; set; }
    }
}