
using Microsoft.EntityFrameworkCore;
using Notes.DAL.Model;


namespace Notes.DAL
{
    public class AppContext : DbContext
    {
        public DbSet<Note> Notes { get; set; }
       

        public AppContext(DbContextOptions<AppContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
