using Microsoft.AspNetCore.Mvc;

namespace EmprestimosLivros.Controllers
{
    public class TesteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
