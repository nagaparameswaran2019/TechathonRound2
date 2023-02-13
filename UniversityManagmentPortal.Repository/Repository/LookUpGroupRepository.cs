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
    public class LookUpGroupRepository :  ILookUpGroupRepository
    {
        protected readonly DbSet<LookUpGroup> _dbSet;
        private readonly ApplicationDbContext _context;

        public LookUpGroupRepository(ApplicationDbContext context)  
        {
            _context = context;
            _dbSet = context.Set<LookUpGroup>();
        }

        public List<LookUpGroup> GetLookupGroupByName(string? groupNames)
        {
            List<string> groupNameList = !string.IsNullOrEmpty(groupNames) ? groupNames.Split(',').Select(s => s.ToLower().Trim()).ToList() : new List<string>();
            List<LookUpGroup> lookUpGroups = null;

            if (string.IsNullOrEmpty(groupNames) || string.Compare(groupNames, "all", true) == 0)
            {
                lookUpGroups = _dbSet.Include(t => t.LookUps).ToList();
            }
            else
            {
                lookUpGroups = _dbSet.Where(t => groupNameList.Any(s => s.Equals(t.Code.ToLower()))).Include(t => t.LookUps).ToList();
            }

            return lookUpGroups;
        }
    }
}
