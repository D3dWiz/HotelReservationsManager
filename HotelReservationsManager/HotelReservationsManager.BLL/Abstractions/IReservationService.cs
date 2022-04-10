using HotelReservationsManager.DAL.Entities;

namespace HotelReservationsManager.BLL.Abstractions
{
    public interface IReservationService
    {
        bool CreateReservation(int roomId, Room room, DateTime accommodationDate, DateTime releaseDate,
            bool hasBreakfast, bool isAllInclusive);

        List<Reservation> GetReservations();

        Reservation GetReservationById(int reservationId);

        bool Remove(int reservationId);
    }
}