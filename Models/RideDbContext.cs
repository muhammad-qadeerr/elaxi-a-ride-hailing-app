using Microsoft.EntityFrameworkCore;
namespace Ride_Booking_Application.Models
{
    public class RideDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
            => optionBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ElaxiDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        public DbSet<MyLoginSignup> MyLoginSignups { get; set; }
    }
}
