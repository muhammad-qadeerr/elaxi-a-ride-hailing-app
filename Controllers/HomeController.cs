using Microsoft.AspNetCore.Mvc;
using Ride_Booking_Application.Models;
using System.Diagnostics;

namespace Ride_Booking_Application.Controllers
{
    public class HomeController : Controller
    {
        RideRepository rideRepository  = new RideRepository();
        public IActionResult home()
        {
            return View();
        }

        [HttpPost]
        public IActionResult home(MyLoginSignup Signup)
        {
            rideRepository.addSignUpDetails(Signup);
           
            return View();
        }
    }
}