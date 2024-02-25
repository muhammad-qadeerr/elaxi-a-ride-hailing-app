using Microsoft.AspNetCore.Mvc;

namespace Ride_Booking_Application.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult about()
        {
            return View();
        }
    }
}
