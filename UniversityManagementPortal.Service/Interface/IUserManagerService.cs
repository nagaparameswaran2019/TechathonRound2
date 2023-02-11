using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagementPortal.UIModel;

namespace UniversityManagementPortal.Service.Interface
{
    public interface IUserManagerService
    {
        Task<Result<StudentViewModel>> CreateIndentityUser(StudentViewModel studentViewModel, string role);
    }
}
