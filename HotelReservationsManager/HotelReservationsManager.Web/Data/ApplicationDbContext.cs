using HotelReservationsManager.DAL.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HotelReservationsManager.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ClientReservationHistory> ClientReservationHistories { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //
        //    foreach (var property in builder.Model.GetEntityTypes()
        //        .SelectMany(t => t.GetProperties())
        //        .Where(p => p.ClrType == typeof(decimal) || p.ClrType == typeof(decimal?)))
        //    {
        //
        //      property.Relational().ColumnType = "decimal(18,2)";
        //    }
        //}
    }
}