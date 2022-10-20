using Notes.DAL;

namespace Notes.BLL.Interfaces
{
    public interface IService
    {
        public UnitOfWork Uow { get; set; }
        public void SpellCheck();
    }
}
