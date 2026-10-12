
using System.Web.Mvc;
using MVC_BasicTutorials.Models;

namespace MVC_BasicTutorials.Controllers
{
    public class PersonDetailsController : Controller
    {
        public ActionResult UserDetails()
        {
            return View("UserDetails", new User());
        }
    }
}
