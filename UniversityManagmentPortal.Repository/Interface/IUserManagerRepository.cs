using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagementPortalEntity.Model;

namespace UniversityManagmentPortal.Repository.Interface
{
    public interface IUserManagerRepository
    {
        Task<IdentityResult> CreateIndentityUser(IdentityUser applicationUser, string role);
    }
}
