using Microsoft.AspNetCore.Mvc;

namespace AppSemTemplate.Areas.Vendas.Controllers
{
    [Area("Vendas")]
    public class GestaoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Detalhes(int Id)
        {
            _ = Id;
            return View("Index");
        }
    }
}
