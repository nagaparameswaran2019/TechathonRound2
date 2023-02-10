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
    public class StudentRepository : IStudentRepository
    {

        protected readonly DbSet<Student> _dbSet;
        private readonly ApplicationDbContext _context;
        public StudentRepository(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = context.Set<Student>();
        }

        public void AddOrUpdateStudentDetails(Student student)
        {
            try
            {
                if (student.StudentId == 0)
                {
                    _dbSet.Add(student);
                }
                else
                {
                    _dbSet.Update(student);
                }
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Student> GetAllStudents()
        {
            List<Student> students = new List<Student>();
            students = _dbSet.AsEnumerable().ToList();
            return students;
        }

        public Student GetStudentDetailsById(int id)
        {
            Student student = new Student();
            student = _dbSet.ToList()
                            .FirstOrDefault(s => s.StudentId == id);
            return student;
        }
    }
}
