

namespace Notes.DAL.Interfaces
{
    public interface IRepository<TDbModel>
    {
        public List<TDbModel> GetAll();
        public TDbModel Get(Guid id);
        public void Delete(Guid id);
        public TDbModel Update(TDbModel model);
        public TDbModel Add(TDbModel model);
    }
}
