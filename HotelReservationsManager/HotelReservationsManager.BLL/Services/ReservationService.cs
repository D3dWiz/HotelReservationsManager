using HotelReservationsManager.DAL.Abstractions;
using HotelReservationsManager.DAL.Entities;

namespace HotelReservationsManager.BLL.Services
{
    public class ReservationService
    {
        private readonly IRepository<Reservation> _reservationRepository;

        public ReservationService(IRepository<Reservation> reservationRepository)
        {
            _reservationRepository = reservationRepository;
        }

        public bool CreateReservation(int roomId, Room room, DateTime accommodationDate, DateTime releaseDate,
            bool hasBreakfast, bool isAllInclusive)
        {
            var reservation = new Reservation()
            {
                RoomId = roomId,
                AccommodationDate = accommodationDate,
                ReleaseDate = releaseDate,
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