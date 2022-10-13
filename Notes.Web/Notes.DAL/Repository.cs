using Notes.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using Notes.DAL.Model;
using EntityState = System.Data.Entity.EntityState;

namespace Notes.DAL
{
    public class Repository<TDbModel> : IRepository<TDbModel> where TDbModel : Note
    {
        private AppContext Context;
        public Repository(AppContext context)
        {
            Context = context;
        }

        public List<TDbModel> GetAll()
        {
            return Context.Set<TDbModel>().ToList();
        }

        public TDbModel Get(Guid id)
        {
            return Context.Set<TDbModel>().FirstOrDefault(m => m.Id == id);
        }

        public void Delete(Guid id)
        {
            var toDelete = Context.Set<TDbModel>().FirstOrDefault(m => m.Id == id);
            Context.Set<TDbModel>().Remove(toDelete);
            Context.SaveChanges();
        }

        public void Update(TDbModel model)
        {
            Context.Entry(model).State = EntityState.Modified;
        }

        public TDbModel Add(TDbModel model)
        {
            Context.Set<TDbModel>().Add(model);
            Context.SaveChanges();
            return model;
        }
    }
}
