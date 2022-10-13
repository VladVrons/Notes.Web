
using Notes.DAL.Model;
using System.Data.Entity;

namespace Notes.DAL
{
    public class AppContext : DbContext
    {
        public DbSet<Note> Notes { get; set; }


        static AppContext()
        {
            Database.SetInitializer<AppContext>(new AppDbInitializer());
        }

        public AppContext(string connectionString) : base(connectionString)
        {

        }
    }

    public class AppDbInitializer : DropCreateDatabaseIfModelChanges<AppContext>
    {
        protected override void Seed(AppContext db)
        {
            db.Notes.Add(new Note { Id = System.Guid.NewGuid(), Title="First word", Detail="Hello world" }); ; ;    
            db.SaveChanges();
        }
    }


}

