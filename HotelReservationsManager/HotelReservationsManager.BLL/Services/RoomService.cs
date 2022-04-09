using HotelReservationsManager.BLL.Abstractions;
using HotelReservationsManager.DAL.Abstractions;
using HotelReservationsManager.DAL.Entities;
using System.Collections.Generic;

namespace HotelReservationsManager.BLL.Services
{
    public class RoomService : IRoomService
    {
        private readonly IRepository<Room> _roomRepository;

        public RoomService(IRepository<Room> roomRepository)
        {
            _roomRepository = roomRepository;
        }

        public bool CreateRoom(int capacity, string type, bool isAvalable, decimal bedPrice, decimal bedPriceChiled, int number)
        {
            var room = new Room()
            {
                Capacity = capacity,
                Type = type,
                IsAvalable = isAvalable,
                BedPrice = bedPrice,
                BedPriceChild = bedPriceChiled,
                Number = number
            };
            return _roomRepository.Create(room);
        }

        public Room GetRoomById(int roomId)
        {
            return _roomRepository.GetById(roomId);
        }

        public List<Room> GetRooms()
        {
            return _roomRepository.GetAll();
        }

        public bool Remove(int roomId)
        {
            return _roomRepository.RemoveById(roomId);
        }

        public bool UpdateRoom(int roomId, int capacity, string type, bool isAvalable, decimal bedPrice, decimal bedPriceChiled, int number)
        {
            var room = _roomRepository.GetById(roomId);
            room.Capacity = capacity;
            room.Type = type;
            room.IsAvalable = isAvalable;
            room.BedPrice = bedPrice;
            room.BedPriceChild = bedPriceChiled;
            room.Number = number;

            return _roomRepository.Update(room);
        }
    }
}