using Microsoft.AspNetCore.Mvc;

namespace AppSemTemplate.Component
{
    public class CounterViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(int modelCounter)
        {
            return View(modelCounter);
        }
    }
}
