namespace HotelReservationsManager.DAL.Entities
{
    public class ClientReservationHistory : BaseEntity
    {
        public ClientReservationHistory(int clientId, int reservationId)
        {
            ClientId = clientId;
            ReservationId = reservationId;
        }

        public int ClientId { get; set; }
        public virtual Client Client { get; set; }
        public int ReservationId { get; set; }
        public virtual Reservation Reservation { get; set; }
    }
}