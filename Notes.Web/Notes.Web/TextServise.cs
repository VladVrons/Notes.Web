using Notes.Web.Interfaces;
using Notes.DAL.Interfaces;
using Notes.DAL.Model;

namespace Notes.Web
{
    public class TextServise : IService
    {
        private IRepository<Note> Notes { get; set; }
       
        public void SpellCheck()
        {
            foreach (Note note in Notes.GetAll())
            {
                note.Detail = UpperText(note.Detail);
                Notes.Update(note);
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
                    s2 = (s.Substring(i + 2, 1).ToUpper());
                    s = s.Replace(s.Substring(i + 2, 1), s2);
                }

            }
            return s;
        }
    }
}
