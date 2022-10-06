
using Notes.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using Notes.DAL.Model;

namespace Notes.DAL
{
    public class Repository<TDbModel> : IRepository<TDbModel>
    {
        private AppContext Context;
        public Repository(AppContext context)
        {
            Context = context;
        }

        public List<TDbModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public TDbModel Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public TDbModel Update(TDbModel model)
        {
            var toUpdate = Context.Set<TDbModel>().FirstOrDefault(m => m.Id == model.Id);
            if (toUpdate != null)
            {
                toUpdate = model;
            }
            Context.Update(toUpdate);
            Context.SaveChanges();
            return toUpdate;
        }

        public TDbModel Add(TDbModel model)
        {
            Context.Set<TDbModel>().Add(model);
            Context.SaveChanges();
            return model;
        }
    }
}
