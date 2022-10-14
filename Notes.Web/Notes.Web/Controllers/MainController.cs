using Microsoft.AspNetCore.Mvc;
using Notes.DAL.Interfaces;
using Notes.DAL.Model;
using Notes.Web.Interfaces;
using Notes.Web.Services;

namespace Notes.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MainController : ControllerBase
    {
        private IService TextService { get; set; }
        private IRepository<Note> Notes { get; set; }

        public MainController()
        {
            TextService = new TextService("localNote");
            
        }
        
        [HttpGet]
        public JsonResult Get()
        {
            TextService.SpellCheck();
            return new JsonResult(TextService.Uow.Notes.GetAll());
        }
        
        [HttpPost]
        public JsonResult Posting(Guid id)
        {
            return new JsonResult(TextService.Uow.Notes.Get(id));
        }
        /*
        [HttpPut]
        public JsonResult Put(Document doc)
        {
            bool success = true;
            var document = Documents.Get(doc.Id);
            try
            {
                if (document != null)
                {
                    document = Documents.Update(doc);
                }
                else
                {
                    success = false;
                }
            }
            catch (Exception)
            {
                success = false;
            }

            return success ? new JsonResult($"Update successful {document.Id}") : new JsonResult("Update was not successful");
        }

        [HttpDelete]
        public JsonResult Delete(Guid id)
        {
            bool success = true;
            var document = Documents.Get(id);

            try
            {
                if (document != null)
                {
                    Documents.Delete(document.Id);
                }
                else
                {
                    success = false;
                }
            }
            catch (Exception)
            {
                success = false;
            }

            return success ? new JsonResult("Delete successful") : new JsonResult("Delete was not successful");
        }*/
    }
}
