using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET Hello World
        public ActionResult Index()
        {
            return View();
        }
        
        //
        //GET HelloWorld/Welcome
        public string Welcome(string name, int num = 1)
        {
            return HttpUtility.HtmlEncode($"Hello {name}, number of times is {num}");
        }
    }
}