using Microsoft.AspNetCore.Mvc;
using Ride_Booking_Application.Models;

namespace Ride_Booking_Application.Controllers
{
    public class SignUpController : Controller
    {
        //RideRepository rideRepository = new RideRepository();

        public IActionResult signup()
        {

            return View();
        }
        //[HttpPost]
        //public IActionResult signup(MyLoginSignup Signup)
        //{
        //    rideRepository.addSignUpDetails(Signup);

        //    return View();
        //}
    }
}
