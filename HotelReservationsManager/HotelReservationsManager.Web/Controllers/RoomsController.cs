using Microsoft.AspNetCore.Mvc;

namespace HotelReservationsManager.Web.Controllers
{
    public class RoomsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
