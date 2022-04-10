using System.ComponentModel;

namespace HotelReservationsManager.DAL.Entities.Enumeration
{
    public enum RoomType
    {
        [Description("Two Single Beds")] TwoBedsRoom = 0,
        [Description("Double Bed Room")] DoubleBedRoom = 1,
        Apartment = 2,
        Penthouse = 3,
        Maisonette = 4
    }
}