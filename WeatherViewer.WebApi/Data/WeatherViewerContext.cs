using Microsoft.EntityFrameworkCore;
using WeatherViewer.WebApiEntities;

namespace WeatherViewer.WebApiData
{
    public partial class WeatherViewerContext : DbContext
    {
      
        public WeatherViewerContext(DbContextOptions<WeatherViewerContext> options)
            : base(options)
        {
            
        }

        public virtual DbSet<City> City { get; set; } = null!;
        public virtual DbSet<Country> Country { get; set; } = null!;
        public virtual DbSet<WeatherData> WeatherData { get; set; } = null!;
     

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }


        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
