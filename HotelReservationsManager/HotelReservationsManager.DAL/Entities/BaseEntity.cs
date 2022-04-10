using System.ComponentModel.DataAnnotations;

namespace HotelReservationsManager.DAL.Entities
{
    public abstract class BaseEntity
    {
        public BaseEntity()
        {
            CreatedAt = DateTime.Now;
        }

        public int Id { get; set; }
        [Display(Name = "Created At")]
        public DateTime CreatedAt { get; set; }
        [Display(Name = "Modified At")]
        public DateTime ModifiedAt { get; set; }
    }
}