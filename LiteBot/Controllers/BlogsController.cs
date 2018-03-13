using System.Web.Mvc;

namespace LiteBot.Controllers
{
    public class BlogsController : Controller
    {
        // GET: Blogs
        public ActionResult Index()
        {
            return View();
        }
    }
}