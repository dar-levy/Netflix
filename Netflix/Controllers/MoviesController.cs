using System.Web.Mvc;
using Netflix.Models;

namespace Netflix.Controllers
{
    public class MoviesController : Controller
    {
        // GET
        public ActionResult Random()
        {
            var movie = new Movie() {Name = "Shrek"};
            return View(movie);
        }
    }
}