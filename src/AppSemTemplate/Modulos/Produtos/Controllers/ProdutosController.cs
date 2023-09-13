using Microsoft.AspNetCore.Mvc;

namespace AppSemTemplate.Areas.Produtos.Controllers
{
    [Area("Produtos")]
    public class ProdutosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Detalhes(int Id)
        {
            _ = Id.ToString();
            return View("Index");
        }
    }
}
