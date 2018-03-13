using Microsoft.AspNetCore.Mvc;

namespace MvcMovie
{
    public class TestController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return
            View();
        }
    }
}