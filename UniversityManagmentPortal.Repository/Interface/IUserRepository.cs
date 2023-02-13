using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagementPortalEntity.Model;

namespace UniversityManagmentPortal.Repository.Interface
{
    public interface IUserRepository
    {
        void AddOrUpdateUserDetails(PortalUser  portalUser);
        List<PortalUser> GetAllUsersByRoleId(string roleId);
        PortalUser GetUserDetailsById(int id);
        List<PortalUser> GetAllUsers();
    }
}
