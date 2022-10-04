using EntityFramework_SliderTask.Models;
using Microsoft.EntityFrameworkCore;


namespace EntityFramework_SliderTask.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
        }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SliderDetail> SliderDetails { get; set; }
    }
}
