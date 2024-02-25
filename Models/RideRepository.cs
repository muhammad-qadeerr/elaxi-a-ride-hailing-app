namespace Ride_Booking_Application.Models
{
    public class RideRepository
    {
        RideDbContext dbContext = new RideDbContext();

        public void addSignUpDetails(MyLoginSignup Signup)
        {
            dbContext.MyLoginSignups.Add(Signup);
            dbContext.SaveChanges();

        }
    }
}
