using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace DemoMVC.Controllers
{
    public class DangnhaphethongController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}