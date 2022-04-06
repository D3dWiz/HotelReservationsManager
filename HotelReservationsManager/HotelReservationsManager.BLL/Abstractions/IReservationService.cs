using HotelReservationsManager.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationsManager.BLL.Abstractions
{
    interface IReservationService
    {
        //int RoomNum
        //ICollection<Client> People
        //DateTime Accommodation
        //DateTime Release
        //bool IsBreakfast
        //bool IsAllInclusive
        //Room Room
        //decimal Price
        
        bool CreateReservation(int roomNum, DateTime accommodation, DateTime release,
            bool isBreakfast, bool isAllInclusive, Room room);
        List<Reservation> GetReservations();
        Reservation GetReservationById(int reservationId);
        bool Remove(int reservationId);
    }
}
