using Notes.DAL;

namespace Notes.Web.Interfaces
{
    public interface IService
    {
        public UnitOfWork Uow { get; set; }
        public void SpellCheck();
    }
}
