using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace HotelReservationsManager.DAL.Entities
{
    public class User : IdentityUser<string>
    {
        public User()
        {
        }

        public User(User user)
        {
            Id = user.Id;
            UserName = user.UserName;
            Password = user.Password;
            //Role = user.Role;
            FirstName = user.FirstName;
            MiddleName = user.MiddleName;
            LastName = user.LastName;
            IDN = user.IDN;
            Phone = user.Phone;
            Email = user.Email;
            AppointmentDate = user.AppointmentDate;
            IsActive = user.IsActive;
            IsAdmin = user.IsAdmin;
            DismissalDate = DismissalDate;
        }
        [Display(Name = "Username")]
        public string UserName { get; set; }
        public string Password { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string IDN { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        [Display(Name = "Appointment")]
        public DateTime AppointmentDate { get; set; }
        public bool IsActive { get; set; }
        public bool IsAdmin { get; set; }
        [Display(Name = "Dismissal")]
        public DateTime? DismissalDate { get; set; }
        [Display(Name = "Created At")]
        public DateTime CreatedAt { get; set; }
        [Display(Name = "Modified At")]
        public DateTime ModifiedAt { get; set; }
    }
}