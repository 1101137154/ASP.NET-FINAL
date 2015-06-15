using KuasCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuasCore.Dao
{
    public interface IStudentDao
    {
         void AddStudent(Student student);

         void UpdateStudent(Student student);

         void DeleteStudent(Student student);

         IList<Student> GetAllStudent();

         Student GetStudentByName(string name);

         Student GetStudentById(int id);

    }
}
