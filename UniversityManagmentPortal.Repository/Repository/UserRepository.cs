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
    public class UserRepository : IUserRepository
    {

        protected readonly DbSet<PortalUser> _dbSet;
        protected readonly DbSet<ApplicationRole> _dbRoleSet;

        private readonly ApplicationDbContext _context;
        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = context.Set<PortalUser>();
            _dbRoleSet = context.Set<ApplicationRole>();
        }

        public void AddOrUpdateUserDetails(PortalUser portalUser)
        {
            try
            {
                var sss = _dbRoleSet.FirstOrDefault();
                if (portalUser.Id == 0)
                {
                    _dbSet.Add(portalUser);
                }
                else
                {
                    _dbSet.Update(portalUser);
                }
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<PortalUser> GetAllUsers()
        {

            List<PortalUser> portalUsers = new List<PortalUser>();
            portalUsers = _dbSet.AsEnumerable().ToList();
            return portalUsers;
        }

        public List<PortalUser> GetAllUsersByRoleId(string roleId)
        {

            List<PortalUser> portalUsers = new List<PortalUser>();
            portalUsers = _dbSet.Where(s => s.RoleId == roleId).AsEnumerable().ToList();
            return portalUsers;
        }

        public PortalUser GetUserDetailsById(int id)
        {

            PortalUser portalUser = new PortalUser();
            portalUser = _dbSet.ToList()
                            .FirstOrDefault(s => s.Id == id);
            return portalUser;
        }
    }
}
