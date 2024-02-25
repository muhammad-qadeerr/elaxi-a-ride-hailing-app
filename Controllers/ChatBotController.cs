using Microsoft.AspNetCore.Mvc;

namespace Ride_Booking_Application.Controllers
{
    public class ChatBotController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
