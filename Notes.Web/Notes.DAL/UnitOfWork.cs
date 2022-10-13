using Notes.DAL.Interfaces;
using Notes.DAL.Model;
namespace Notes.DAL
{
    public class UnitOfWork 
    {
        private AppContext db;
        private Repository<Note> noteRepository;
        //private TicketRepository ticketRepository;

        public UnitOfWork(string connectionString)
        {
            db = new AppContext(connectionString);
        }

        public IRepository<Note> Notes
        {
            get
            {
                if (noteRepository == null)
                    noteRepository = new Repository<Note>(db);
                return noteRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }


}
