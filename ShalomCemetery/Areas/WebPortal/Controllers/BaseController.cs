using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Plugins;

namespace ShalomCemetery.Areas.WebPortal.Controllers
{
    public class BaseController : Controller
    {
        private ISender _mediator;
        protected ISender Mediator => _mediator ??= HttpContext.RequestServices.GetService<ISender>();
    }
}
