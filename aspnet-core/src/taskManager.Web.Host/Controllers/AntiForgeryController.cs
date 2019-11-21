using Microsoft.AspNetCore.Antiforgery;
using taskManager.Controllers;

namespace taskManager.Web.Host.Controllers
{
    public class AntiForgeryController : taskManagerControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
