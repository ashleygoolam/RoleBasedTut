using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace RoleBasedTut.Controllers
{
    [Authorize(Roles = "Admin")] //[Authorize(Roles = "Admin,Users,Managers")]
    public class InventoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
