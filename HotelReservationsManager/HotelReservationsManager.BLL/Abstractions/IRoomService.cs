using HotelReservationsManager.DAL.Entities;

namespace HotelReservationsManager.BLL.Abstractions
{
    public interface IRoomService
    {
        bool CreateRoom(int id, int capacity, string type, bool isAvalable,
            decimal bedPriceAdult, decimal bedPriceChild, int number);

        bool UpdateRoom(int id, int capacity, string type, bool isAvalable,
            decimal bedPriceAdult, decimal bedPriceChild, int number);

        List<Room> GetRooms();

        Room GetRoomById(int id);

        bool Remove(int id);
    }
}