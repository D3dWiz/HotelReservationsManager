using HotelReservationsManager.DAL.Entities;
using System;
using System.Collections.Generic;

namespace HotelReservationsManager.BLL.Abstractions
{
    public interface IReservationService
    {
        //int RoomNum
        //ICollection<ClientReservations> Clients
        //DateTime Accommodation
        //DateTime Release
        //bool HasBreakfast
        //bool IsAllInclusive
        //Room Room
        //decimal Price

        bool CreateReservation(int roomNum, DateTime accommodation, DateTime release,
            bool hasBreakfast, bool isAllInclusive, Room room);

        List<Reservation> GetReservations();

        Reservation GetReservationById(int reservationId);

        bool Remove(int reservationId);
    }
}