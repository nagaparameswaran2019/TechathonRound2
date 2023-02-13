using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagementPortal.UIModel;
using UniversityManagementPortalEntity.Model;

namespace UniversityManagementPortal.Service.Interface
{
    public interface IUserService
    {
        void AddOrUpdateUserDetails(string netUserId, string name, string website, string roleId);
        List<PortalUserViewModel> GetAllUsersByRoleId(string roleId);
        List<LookUpViewModel> GetAllUserLookupByRoleId(string roleId);
    }
}
