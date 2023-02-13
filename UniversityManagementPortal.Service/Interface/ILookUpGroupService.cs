using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagementPortal.UIModel;

namespace UniversityManagementPortal.Service.Interface
{
    public interface ILookUpGroupService
    {
        Result<List<LookUpGroupViewModel>> GetLookupGroupByName(string? groupNames);
    }
}
