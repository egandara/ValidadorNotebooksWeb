using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace NotebookValidator.Web.Controllers
{
    [Authorize] // Protegemos la página para que solo usuarios logueados puedan acceder
    public class GeminiDocController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}