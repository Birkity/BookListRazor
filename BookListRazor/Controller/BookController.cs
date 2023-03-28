using Microsoft.AspNetCore.Mvc;

namespace BookListRazor.Controller
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
