using Notes.DAL;
using Notes.DAL.Interfaces;
using Notes.DAL.Model;
using Xunit;

namespace Notes.Tests
{
    public class DBTest
    {
        private UnitOfWork uOW = new UnitOfWork("localNote");

        [Fact]
        public void GetAll_ReturnFirstTitle()
        {
            var title = uOW.Notes.GetAll().First().Title;
            Assert.Equal("First word", title);
        }
    }
}
