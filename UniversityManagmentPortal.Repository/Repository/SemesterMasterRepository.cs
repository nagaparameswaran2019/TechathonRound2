using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UniversityManagementPortalEntity;
using UniversityManagementPortalEntity.Model;
using UniversityManagmentPortal.Repository.Interface;

namespace UniversityManagmentPortal.Repository.Repository
{
    public class SemesterMasterRepository : ISemesterMasterRepository
    {
        protected readonly DbSet<SemesterMaster> _dbSet;
        private readonly ApplicationDbContext _context;

        public SemesterMasterRepository(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = context.Set<SemesterMaster>();
        }

        public List<SemesterMaster> GetSubjectBySemester(string programCode, string semeseterCode, string yearCode)
        {
            List<SemesterMaster>  semesterMasters  = new List<SemesterMaster>();
            semesterMasters = _dbSet.Where(t => t.ProgramCode == programCode && t.SemeseterCode == semeseterCode && t.YearCode == yearCode).ToList();
            return semesterMasters;
        }
    }
}
