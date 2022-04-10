using System.ComponentModel.DataAnnotations;

namespace HotelReservationsManager.DAL.Entities
{
    public class Room : BaseEntity
    {
        public Room()
        {
        }

        public Room(Room room)
        {
            Id = room.Id;
            Capacity = room.Capacity;
            Type = room.Type;
            IsAvailable = room.IsAvailable;
            BedPriceAdult = room.BedPriceAdult;
            BedPriceChild = room.BedPriceChild;
            Number = room.Number;
        }

        public int Capacity { get; set; }
        public string Type { get; set; }
        [Display(Name = "Available")]
        public bool IsAvailable { get; set; }
        [Display(Name = "Price for adults")]
        public decimal BedPriceAdult { get; set; }
        [Display(Name = "Price for children")]
        public decimal BedPriceChild { get; set; }
        [Display(Name = "Room Number")]
        public int Number { get; set; }
    }
}