namespace HotelReservationsManager.Web.Models.ViewModels.Rooms
{
    public class RoomsDetailsViewModel
    {
        public int Capacity { get; set; }
        public string Type { get; set; }
        public string IsAvalable { get; set; }
        public decimal BedPriceAdult { get; set; }
        public decimal BedPriceChild { get; set; }
        public string Number { get; set; }
    }
}
