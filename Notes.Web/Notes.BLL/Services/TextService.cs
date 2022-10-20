using Notes.DAL.Interfaces;
using Notes.DAL.Model;
using Notes.DAL;
using Notes.BLL.Interfaces;

namespace Notes.BLL.Services
{
    public class TextService : IService
    {
        //public IRepository<Note> Notes { get; set; }

        public UnitOfWork Uow { get; set; }

        public TextService(string databaseName)
        {
            Uow = new UnitOfWork(databaseName);          
        }

        public void SpellCheck()
        {
            foreach (Note note in Uow.Notes.GetAll())
            {
                note.Detail = UpperText(note.Detail);
                Uow.Notes.Update(note);
            }
        }

        private string UpperText(string s)
        {

            string s1, s2;
            int n;

            n = s.Length;
            for (int i = 0; i < n; i++)
            {
                s1 = s.Substring(i, 1);
                if (s1 == ".")
                {
                    s2 = s.Substring(i + 2, 1).ToUpper();
                    s = s.Replace(s.Substring(i + 2, 1), s2);
                }

            }
            return s;
        }
    }
}
