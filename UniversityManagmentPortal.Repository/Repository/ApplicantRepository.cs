using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagementPortalEntity;
using UniversityManagementPortalEntity.Model;
using UniversityManagmentPortal.Repository.Interface;

namespace UniversityManagmentPortal.Repository.Repository
{
    public class ApplicantRepository : IApplicantRepository
    {

        protected readonly DbSet<Applicant> _dbSet;
        private readonly ApplicationDbContext _context;
        public ApplicantRepository(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = context.Set<Applicant>();
        }

        public int AddApplicantDetails(Applicant applicant)
        {
            try
            {
                if (applicant.Id == 0)
                {
                    var result = _dbSet.Add(applicant);
                }
                else
                {
                    _dbSet.Update(applicant);
                }
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return applicant.Id;
        }



        public List<Applicant> GetAllApplicantsByUniveristyId(string id)
        {
            List<Applicant> applicants = new List<Applicant>();
            applicants = _dbSet.Where(s => s.UniversityCode == id).ToList();
            return applicants;

        }

    }
}
