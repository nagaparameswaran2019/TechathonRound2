using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UniversityManagementPortal.WebApp.Controllers;
using UniversityManagementPortal.WebApp.Models;

namespace UniversityManagementPortalWebApp.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<IdentityUser> _userManager;
        public HomeController(ILogger<HomeController> logger, UserManager<IdentityUser> userManager)
        {
            _logger = logger;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            System.Security.Claims.ClaimsPrincipal currentUser = this.User;
            if (currentUser != null)
            {
                var user = await _userManager.FindByEmailAsync(this.User.Identity.Name);
                var roles = await _userManager.GetRolesAsync(user);
                HttpContext.Session.SetString("Roles", string.Join(",", roles));
                bool isAdmin = currentUser.IsInRole("SuperAdmin");
            }

            //var id = _userManager.GetUserId(User); // Get user id:
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}