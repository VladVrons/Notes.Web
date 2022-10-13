

namespace Notes.DAL.Interfaces
{
    public interface IRepository<TDbModel> where TDbModel : class
    {
        public List<TDbModel> GetAll();
        public TDbModel Get(Guid id);
        public void Delete(Guid id);
        public void Update(TDbModel model);
        public TDbModel Add(TDbModel model);
    }
}
