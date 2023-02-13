

using UniversityManagementPortal.Mapper;
using UniversityManagementPortal.Service.Interface;
using UniversityManagementPortal.UIModel;
using UniversityManagmentPortal.Repository.Interface;

namespace UniversityManagementPortal.Service.Service
{
    public class LookUpGroupService : ILookUpGroupService
    {
       
        ILookUpGroupRepository _lookUpGroupRepository;

        public LookUpGroupService( ILookUpGroupRepository lookUpGroupRepository)
        {
            _lookUpGroupRepository = lookUpGroupRepository;
        }
        public Result<List<LookUpGroupViewModel>> GetLookupGroupByName(string? groupNames)
        {
            var data = _lookUpGroupRepository.GetLookupGroupByName(groupNames);
            var viewData = data.CopyTo<List<LookUpGroupViewModel>>();
            return new Result<List<LookUpGroupViewModel>>("Lookup details get successfully", viewData);
        }
    }
}
