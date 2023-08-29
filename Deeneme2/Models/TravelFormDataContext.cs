using Microsoft.EntityFrameworkCore;

namespace Deeneme2.Models
{
    public class TravelFormDataContext : DbContext
    {
        public TravelFormDataContext(DbContextOptions<TravelFormDataContext> options)
            : base(options)
        {
        }

        public DbSet<TravelForm> TravelFormData { get; set; }
    }
}
