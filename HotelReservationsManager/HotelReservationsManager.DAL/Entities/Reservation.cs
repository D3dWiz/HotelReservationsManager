﻿using System;
using System.Collections.Generic;

namespace HotelReservationsManager.DAL.Entities
{
    public class Reservation : BaseEntity
    {
        public Reservation()
        {
            Clients = new HashSet<Client>();
            Room = new Room();
        }

        private decimal _price = 0;

        public int RoomNum { get; set; }
        public virtual ICollection<Client> Clients { get; set; }
        public DateTime Accommodation { get; set; }
        public DateTime Release { get; set; }
        public bool HasBreakfast { get; set; }
        public bool IsAllInclusive { get; set; }
        public virtual Room Room { get; set; }

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
                _price = (Release - Accommodation).Days *
                    (Room.BedPriceChild * childBeds + Room.BedPrice * beds);
            }
        }
    }
}