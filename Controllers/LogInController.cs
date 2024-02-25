using Microsoft.AspNetCore.Mvc;

namespace Ride_Booking_Application.Controllers
{
    public class LogInController : Controller
    {
        public IActionResult login()
        {
            return View();
        }
    }
}
