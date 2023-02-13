using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagementPortalEntity.Model;

namespace UniversityManagmentPortal.Repository.Interface
{
    public interface IApplicantRepository
    {
        int AddApplicantDetails(Applicant applicant);
        List<Applicant> GetAllApplicantsByUniveristyId(string id);
    }
}
