using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagementPortal.Service.Interface;
using UniversityManagementPortal.UIModel;
using UniversityManagmentPortal.Repository.Interface;

namespace UniversityManagementPortal.Service.Service
{
    public class UserManagerService : IUserManagerService
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IUserManagerRepository _userManagerRepository;

        public UserManagerService(UserManager<IdentityUser> userManager, IUserManagerRepository userManagerRepository)
        {
            _userManager = userManager;
            _userManagerRepository = userManagerRepository;
        }
        //public UserManagerService(IUserManagerRepository userManagerRepository)
        //{
        //    //_userManager = userManager;
        //    _userManagerRepository = userManagerRepository;
        //}
        public async Task<Result<StudentViewModel>> CreateIndentityUser(StudentViewModel studentViewModel, string role)
        {
            IdentityUser identityUser = new IdentityUser();
            identityUser.UserName = studentViewModel.EmailId;
            identityUser.PhoneNumber = studentViewModel.ContactNo1.ToString();
            identityUser.Email = studentViewModel.EmailId;
            var identityResult = await _userManagerRepository.CreateIndentityUser(identityUser, "Student");
            if (identityResult.Succeeded)
            {
                var user = await _userManager.FindByEmailAsync(identityUser.Email);
                studentViewModel.AspNetUsersId = user.Id;
            }
            else
            {
                var errors = identityResult.Errors.Select(s => s.Description).ToList();
                return new Result<StudentViewModel>(String.Join(", ", errors), studentViewModel, false);
            }

            return new Result<StudentViewModel>("Created user successfully", studentViewModel, true);
        }
    }
}
