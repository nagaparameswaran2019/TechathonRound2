using UniversityManagementPortalEntity.Model;
using UniversityManagmentPortal.Repository.Common;

namespace UniversityManagmentPortal.Repository.Interface
{
    public interface ILookUpGroupRepository  
    {
        List<LookUpGroup> GetLookupGroupByName(string? groupNames);
    }
}
