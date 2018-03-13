using System.Web;
using System.Web.Mvc;

namespace LiteBot.Controllers
{
    public class GateWayController : Controller
    {
        // GET: GateWay
        public ActionResult Index(string url)
        {
            if (CheckLogin(Request))
            {
                if (url.ToLower().StartsWith("/login")
                    || url.ToLower().StartsWith("/register")
                    || url.ToLower().StartsWith("/forgotpassword")
                )
                {
                    return Redirect("/Dashboard");
                }
                else
                {
                    return Redirect("/Home");
                }
            }
            else
            {
                return Redirect("/Login");
            }
        }

        public bool CheckLogin(HttpRequestBase request)
        {
            return true;
        }
    }
}