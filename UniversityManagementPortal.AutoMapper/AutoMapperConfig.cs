using AutoMapper;
using UniversityManagementPortal.UIModel;
using UniversityManagementPortalEntity.Model;

namespace UniversityManagementPortal.Mapper
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            base.CreateMap<Student, StudentViewModel>().ReverseMap();
            base.CreateMap<Applicant, ApplicantViewModel>().ReverseMap();
            base.CreateMap<LookUpGroup, LookUpGroupViewModel>().ReverseMap();
            base.CreateMap<LookUp, LookUpViewModel>().ReverseMap();
            base.CreateMap<PortalUser, PortalUserViewModel>().ReverseMap();
            base.CreateMap<SemesterMaster, SemesterMasterViewModel>().ReverseMap();
            base.CreateMap<Exam, ExamViewModel>().ReverseMap();
            base.CreateMap<PortalUser, LookUpViewModel>()
                .ForMember(t => t.Code, opt => opt.MapFrom(src => src.AspNetUserId))
                .ForMember(t => t.Description, opt => opt.MapFrom(src => src.DisplayName))
                .ReverseMap();
        }
    }
}
