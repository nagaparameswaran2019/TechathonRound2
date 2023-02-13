using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagementPortal.Mapper;
using UniversityManagementPortal.Service.Interface;
using UniversityManagementPortal.UIModel;
using UniversityManagementPortalEntity.Model;
using UniversityManagmentPortal.Repository.Interface;

namespace UniversityManagementPortal.Service.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void AddOrUpdateUserDetails(string netUserId, string name, string website, string roleId)
        {
            PortalUser portalUser = new PortalUser();
            portalUser.DisplayName = name;
            portalUser.WebSite = website;
            portalUser.AspNetUserId = netUserId;
            portalUser.RoleId = roleId;
            _userRepository.AddOrUpdateUserDetails(portalUser);
        }

        public List<PortalUserViewModel> GetAllUsersByRoleId(string roleId)
        {
            List<PortalUserViewModel> portalUserViewModels = new List<PortalUserViewModel>();
            var result = _userRepository.GetAllUsersByRoleId(roleId);
            portalUserViewModels = result.CopyTo<List<PortalUserViewModel>>();
            return portalUserViewModels;
        }

        public List<LookUpViewModel> GetAllUserLookupByRoleId(string roleId)
        {
            List<LookUpViewModel> lookUpViewModels = new List<LookUpViewModel>();
            var result = _userRepository.GetAllUsersByRoleId(roleId);
            lookUpViewModels = result.CopyTo<List<LookUpViewModel>>();
            return lookUpViewModels;
        }
    }
}
