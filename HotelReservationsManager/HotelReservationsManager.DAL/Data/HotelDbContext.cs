using HotelReservationsManager.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace HotelReservationsManager.DAL.Data
{
    class HotelDbContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HotelReservationsManager;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}