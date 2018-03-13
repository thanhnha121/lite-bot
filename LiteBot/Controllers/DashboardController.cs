using System.Web.Mvc;
using LiteBot.Business;

namespace LiteBot.Controllers
{
    public class DashboardController : Controller
    {
        private readonly AuthController _auth;
        public DashboardController()
        {
            _auth = new AuthController();
        }
        // GET: Dashboard
        public ActionResult Index()
        {
            if (_auth.CheckLogin(Request))
            {
                ViewBag.IsDashboard = true;
                return View();
            }
            else
            {
                return Redirect("/Login");
            }
        }
    }
}