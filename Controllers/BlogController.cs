using Microsoft.AspNetCore.Mvc;

namespace Ride_Booking_Application.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult blog()
        {
            return View();
        }
    }
}
