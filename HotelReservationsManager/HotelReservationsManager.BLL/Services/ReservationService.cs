using HotelReservationsManager.BLL.Abstractions;
using HotelReservationsManager.DAL.Abstractions;
using HotelReservationsManager.DAL.Entities;
using System;
using System.Collections.Generic;

namespace HotelReservationsManager.BLL.Services
{
    public class ReservationService : IReservationService
    {
        private readonly IRepository<Reservation> _reservationRepository;
        public ReservationService(IRepository<Reservation> reservationRepository)
        {
            _reservationRepository = reservationRepository;
        }

        public bool CreateReservation(int roomNum, DateTime accommodation, DateTime release, bool hasBreakfast, bool isAllInclusive, Room room)
        {
            var reservation = new Reservation()
            {
                RoomNum = roomNum,
                Accommodation = accommodation,
                Release = release,
                HasBreakfast = hasBreakfast,
                IsAllInclusive = isAllInclusive,
                Room = room
            };

            return _reservationRepository.Create(reservation);
        }

        public Reservation GetReservationById(int reservationId)
        {
            return _reservationRepository.GetById(reservationId);
        }

        public List<Reservation> GetReservations()
        {
            return _reservationRepository.GetAll();
        }

        public bool Remove(int reservationId)
        {
            return _reservationRepository.RemoveById(reservationId);
        }
    }
}
