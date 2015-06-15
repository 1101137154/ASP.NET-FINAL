using KuasCore.Dao;
using KuasCore.Dao.Impl;
using KuasCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuasCore.Services.Impl
{
    public class StudentService : IStudentService
    {
        public IStudentDao StudentDao { get; set; }

        public Student AddStudent(Student student)
        {
            StudentDao.AddStudent(student);
            return GetStudentByName(student.stu_name);
        }

        public void UpdateStudent(Student student)
        {
            StudentDao.UpdateStudent(student);
        }

        public void DeleteStudent(Student student)
        {
            student = StudentDao.GetStudentByName(student.stu_name);

            if (student != null)
            {
                StudentDao.DeleteStudent(student);
            }
        }

        public IList<Student> GetAllStudent()
        {
            return StudentDao.GetAllStudent();
        }

        public Student GetStudentByName(string name)
        {
            return StudentDao.GetStudentByName(name);
        }

        public Student GetStudentById(int id)
        {
            return StudentDao.GetStudentById(id);
        }
    }
}
