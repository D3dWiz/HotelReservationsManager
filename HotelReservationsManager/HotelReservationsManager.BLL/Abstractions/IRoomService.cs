using HotelReservationsManager.DAL.Entities;
using System.Collections.Generic;

namespace HotelReservationsManager.BLL.Abstractions
{
    interface IRoomService
    {
        //Capacity
        //Type
        //IsAvalable
        //BedPrice
        //BedPriceChild
        //Number

        bool CreateRoom(int capacity, string type, bool isAvalable,
            decimal bedPrice, decimal bedPriceChiled, int number);
        bool UpdateRoom(int roomId, int capacity, string type, bool isAvalable,
            decimal bedPrice, decimal bedPriceChiled, int number);
        List<Room> GetRooms();
        Room GetRoomById(int roomId);
        bool Remove(int roomId);
    }
}
