using Microsoft.AspNetCore.Mvc;

namespace ShalomCemetery.Areas.WebPortal.Controllers
{
    public class AuthorizeController : BaseController
    {
        public IActionResult Index()
        {
            return View("~/Areas/WebPortal/Views/Authorize/Index.cshtml");
        }
    }
}
