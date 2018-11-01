using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
namespace RolebaseAuthorization.Controllers
{
    public class TestController : Controller
    {
        [Authorize(Roles = "Admin")]
        public IActionResult OnlyAdminAccess()
        {
            ViewData["role"] = "Admin";
            return View("MyPage");
        }

        [Authorize(Roles = "User,Admin,User")]
        public IActionResult OnlyUserAccess()
        {
            ViewData["role"] = "User";
            return View("MyPage");
        }
        [Authorize(Roles = "Staff")]
        public IActionResult OnlyHRAccess()
        {
            ViewData["role"] = "Staff";
            return View("MyPage");
        }
        
    }
}