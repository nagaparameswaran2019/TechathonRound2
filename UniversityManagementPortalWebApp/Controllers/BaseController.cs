using Microsoft.AspNetCore.Mvc;

namespace UniversityManagementPortal.WebApp.Controllers
{
    public class BaseController : Controller
    {
        public BaseController() {
            System.Security.Claims.ClaimsPrincipal currentUser = this.User;
            if (currentUser != null)
            {
                bool isAdmin = currentUser.IsInRole("SuperAdmin");
            }
        }
    }
}
