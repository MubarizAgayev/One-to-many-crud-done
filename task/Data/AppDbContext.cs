using Microsoft.EntityFrameworkCore;
using Project.Models;

namespace Project.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseHost> CourseHosts { get; set; }
        public DbSet<CourseImage> CourseImages { get; set; }
        public DbSet<Events> Events { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<NewsOwner> NewsOwners { get; set; }
        public DbSet<NewsImage> NewsImages { get; set; }
    }
}
