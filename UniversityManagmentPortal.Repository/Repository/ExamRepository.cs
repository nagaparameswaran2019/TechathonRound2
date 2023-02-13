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
    public class ExamRepository : IExamRepository
    {
        protected readonly DbSet<Exam> _dbSet;
        private readonly ApplicationDbContext _context;

        public ExamRepository(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = context.Set<Exam>();
        }

        public void AddOrUpdateExam(List<Exam> exam)
        {
            try
            {
                exam.ForEach(input =>
                {
                    if (input.Id == 0)
                    {
                        _dbSet.Add(input);
                    }
                    else
                    {
                        _dbSet.Update(input);
                    }
                });
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Exam> GetAllExma(string programCode, string semeseterCode, string yearCode)
        {
            throw new NotImplementedException();
        }
    }
}
