using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagmentPortal.Repository.Interface;
using UniversityManagementPortalEntity;

namespace CampusRecruitment.Repository.Repository
{
    public class LookUpRepository : ILookUpRepository
    {
        private ApplicationDbContext _context = null;

        public LookUpRepository(ApplicationDbContext context)  
        {
            _context = context;
        }
    }
}
