

using UniversityManagementPortal.Mapper;
using UniversityManagementPortal.Service.Interface;
using UniversityManagementPortal.UIModel;
using UniversityManagmentPortal.Repository.Interface;
using UniversityManagmentPortal.Repository.Repository;

namespace UniversityManagementPortal.Service.Service
{
    public class SemesterMasterService : ISemesterMasterService
    {
        ISemesterMasterRepository _semesterMasterRepository;
        ILookUpGroupService _lookUpGroupService;
        public SemesterMasterService(ISemesterMasterRepository semesterMasterRepository, ILookUpGroupService lookUpGroupService)
        {
            _semesterMasterRepository = semesterMasterRepository;
            _lookUpGroupService = lookUpGroupService;
        }

        public List<SemesterMasterViewModel> GetAllSubjectBySemester(string programCode, string semeseterCode, string yearCode)
        {
            var lookupResult = _lookUpGroupService.GetLookupGroupByName("SUBJ").Data.FirstOrDefault()?.LookUps;

            List<SemesterMasterViewModel> semesterMasters = new List<SemesterMasterViewModel>();
            var result = _semesterMasterRepository.GetSubjectBySemester(programCode, semeseterCode, yearCode);
            semesterMasters = result.CopyTo<List<SemesterMasterViewModel>>();
            if (lookupResult != null && result != null)
            {
                semesterMasters.ForEach(record =>
                {
                    record.Subject = lookupResult.FirstOrDefault(item => item.Code == record.SubjectCode)?.Description;
                });
            }
            return semesterMasters;
        }
    }
}
