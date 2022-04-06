namespace HotelReservationsManager.DAL.Entities
{
    public class Room : BaseEntity
    {
        public int Capacity { get; set; }
        public string Type { get; set; }
        public bool IsAvalable { get; set; }
        public decimal BedPrice { get; set; }
        public decimal BedPriceChild { get; set; }
        public int Number { get; set; }
    }
}