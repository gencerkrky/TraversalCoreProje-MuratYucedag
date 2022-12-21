using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.ViewComponents.Default
{
    public class _Testimonial:ViewComponent
    {
       public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
