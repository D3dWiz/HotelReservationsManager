namespace HotelReservationsManager.DAL.Entities
{
    public class Reservation : BaseEntity
    {
        public Reservation()
        {
            ClientReservationHistory = new HashSet<ClientReservationHistory>();
        }

        public Reservation(Reservation reservation)
        {
            Id = reservation.Id;
            Room = new Room(reservation.Room);
            User = new User(reservation.User);
            AccommodationDate = reservation.AccommodationDate;
            IsAllInclusive = reservation.IsAllInclusive;
            Price = reservation.Price;
            ClientReservationHistory = reservation.ClientReservationHistory;
        }

        private decimal _price = 0;

        public int RoomId { get; set; }
        public virtual Room Room { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public DateTime AccommodationDate { get; set; }
        public DateTime ReleaseDate { get; set; }
        public bool HasBreakfast { get; set; }
        public bool IsAllInclusive { get; set; }

        public decimal Price
        {
            get
            {
                return _price;
            }
            set
            {
                var childBeds = 0;
                var beds = 0;
                foreach (var client in Clients)
                {
                    if (client.IsAdult)
                        beds++;
                    else
                        childBeds++;
                }
                _price = (ReleaseDate - AccommodationDate).Days *
                    (Room.BedPriceChild * childBeds + Room.BedPriceAdult * beds);
            }
        }

        public virtual ICollection<Client> Clients { get; set; }
        public virtual ICollection<ClientReservationHistory> ClientReservationHistory { get; set; }
    }
}