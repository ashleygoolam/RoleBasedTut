using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RoleBasedTut.Enums;

namespace RoleBasedTut.Controllers
{
    [Authorize]
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
