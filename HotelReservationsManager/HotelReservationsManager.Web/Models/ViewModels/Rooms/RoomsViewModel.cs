namespace HotelReservationsManager.Web.Models.ViewModels.Rooms
{
    public class RoomsViewModel
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public int Capacity { get; set; }
        public string Type { get; set; }
        public string IsAvailable { get; set; }
        public decimal BedPriceAdult { get; set; }
        public decimal BedPriceChild { get; set; }
    }
}
