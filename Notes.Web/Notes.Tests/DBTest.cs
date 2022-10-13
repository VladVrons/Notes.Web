using Notes.DAL;
using Notes.DAL.Model;
using Xunit;

namespace Notes.Tests
{
    public class DBTest
    {
        private UnitOfWork uOW = new UnitOfWork("localNote");
        private Guid guid;
        [Fact]
        public void GetAll_ReturnFirstTitle()
        {
            var note = uOW.Notes.GetAll().First();
            Assert.Equal("hello there", note.Title);
        }

        [Fact]
        public void AddNewNote_ReturnFirstTitle()
        {
            var note = uOW.Notes.Add(new Note { Id = System.Guid.NewGuid(), Title = "hello there", Detail = "obi1kenobe" });
            Assert.Equal("hello there", note.Title);
        }
        [Fact]
        public void DeleteNewNote_ReturnFirstTitle()
        {
            
            //uOW.Notes.Delete(note.Id);
            //Assert.NotNull(uOW.Notes.Get(note.Id));
        }

    }
}
