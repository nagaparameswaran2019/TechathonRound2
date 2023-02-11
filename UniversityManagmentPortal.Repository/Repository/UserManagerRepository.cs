using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagementPortalEntity;
using UniversityManagementPortalEntity.Model;
using UniversityManagmentPortal.Repository.Interface;

namespace UniversityManagmentPortal.Repository.Repository
{
    public class UserManagerRepository : IUserManagerRepository
    {
        //private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IUserStore<IdentityUser> _userStore;
        private readonly IUserEmailStore<IdentityUser> _emailStore;
        //private readonly ILogger<RegisterModel> _logger;
        //private readonly IEmailSender _emailSender;
        //private readonly IServiceProvider _serviceProvider;
        //protected readonly DbSet<IdentityUser> _dbSet;
        //ApplicationDbContext context,
        //private readonly ApplicationDbContext _context;
        public UserManagerRepository(UserManager<IdentityUser> userManager, IUserStore<IdentityUser> userStore)
        {
            //_context = context;
            //_dbSet = context.Set<IdentityUser>();
            _userManager = userManager;
            _userStore = userStore;
            _emailStore = GetEmailStore();
            //_dbUserRoleSet = context.Set<IdentityUserRole>();
            //_userStore = userStore;
        }
        public async Task<IdentityResult> CreateIndentityUser(IdentityUser applicationUser, string role)
        {

            var user = CreateUser();
            user.UserName = applicationUser.UserName;
            user.PhoneNumber = applicationUser.PhoneNumber;
            user.EmailConfirmed = true; //TODO: replaced once email comfimantion trigger
            user.PhoneNumberConfirmed = applicationUser.PhoneNumberConfirmed;
            user.Email = applicationUser.Email;
            user.PasswordHash = "Test@123";
            await _userStore.SetUserNameAsync(user, user.Email, CancellationToken.None);
            await _emailStore.SetEmailAsync(user, user.Email, CancellationToken.None);
            var result = await _userManager.CreateAsync(user, "Test@123");
            if (result.Succeeded)
            {
                //ToDo Send email to verify the email and enable the login
                var resultRole = await _userManager.AddToRoleAsync(user, role);
            }
            
            return result;
        }

        private IdentityUser CreateUser()
        {
            try
            {
                return Activator.CreateInstance<IdentityUser>();
            }
            catch
            {
                throw new InvalidOperationException($"Can't create an instance of '{nameof(IdentityUser)}'. " +
                    $"Ensure that '{nameof(IdentityUser)}' is not an abstract class and has a parameterless constructor, or alternatively " +
                    $"override the register page in /Areas/Identity/Pages/Account/Register.cshtml");
            }
        }

        private IUserEmailStore<IdentityUser> GetEmailStore()
        {
            if (!_userManager.SupportsUserEmail)
            {
                throw new NotSupportedException("The default UI requires a user store with email support.");
            }
            return (IUserEmailStore<IdentityUser>)_userStore;
        }
    }
}
