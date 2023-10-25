using AppSemTemplate.Configuration;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace AppSemTemplate.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration Configuration;

        private readonly ApiConfiguration ApiConfig;

        public HomeController(IConfiguration configuration,
                              IOptions<ApiConfiguration> apiConfiguration)
        {
            Configuration = configuration;
            ApiConfig = apiConfiguration.Value;
        }

        public IActionResult Index()
        {
            var env = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            return View();
        }
    }
}
