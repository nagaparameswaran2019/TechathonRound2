using AutoMapper;
using UniversityManagementPortal.UIModel;
using UniversityManagementPortalEntity.Model;

namespace UniversityManagementPortal.AutoMapper.Mapper
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            base.CreateMap<Student, StudentViewModel>().ReverseMap();
        }
    }
}
