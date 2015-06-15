using KuasCore.Dao.Base;
using KuasCore.Dao.Mapper;
using KuasCore.Models;
using Spring.Data.Common;
using Spring.Data.Generic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuasCore.Dao.Impl
{
    public class StudentDao : GenericDao<Student>, IStudentDao
    {
        override protected IRowMapper<Student> GetRowMapper()
        {
            return new StudentRowMapper();
        }

        public void AddStudent(Student student)
        {
            string command = @"INSERT INTO Students (stu_id, stu_name, stu_phone,stu_birth,stu_info) VALUES (@sid, @name, @phone,@birth,@info);";

            IDbParameters parameters = CreateDbParameters();
            parameters.Add("sid", DbType.String).Value = student.stu_id;
            parameters.Add("name", DbType.String).Value = student.stu_name;
            parameters.Add("phone", DbType.String).Value = student.stu_phone;
            parameters.Add("birth", DbType.DateTime).Value = student.stu_birth;
            parameters.Add("info", DbType.String).Value = student.stu_info;

            ExecuteNonQuery(command, parameters);
        }

        public void UpdateStudent(Student student)
        {
            string command = @"UPDATE Students SET stu_id = @sid, stu_name = @name, stu_phone = @phone,stu_birth = @birth,stu_info = @info where id = @id;";

            IDbParameters parameters = CreateDbParameters();
            parameters.Add("id", DbType.String).Value = student.id;
            parameters.Add("sid", DbType.String).Value = student.stu_id;
            parameters.Add("name", DbType.String).Value = student.stu_name;
            parameters.Add("phone", DbType.String).Value = student.stu_phone;
            parameters.Add("birth", DbType.DateTime).Value = student.stu_birth;
            parameters.Add("info", DbType.String).Value = student.stu_info;

            ExecuteNonQuery(command, parameters);
        }

        public void DeleteStudent(Student student)
        {
            string command = @"DELETE FROM Students WHERE id = @id";

            IDbParameters parameters = CreateDbParameters();
            parameters.Add("id", DbType.Int32).Value = student.id;

            ExecuteNonQuery(command, parameters);
        }

        public IList<Student> GetAllStudent()
        {
            string command = @"SELECT * FROM Students ORDER BY stu_id ASC";
            IList<Student> student = ExecuteQueryWithRowMapper(command);
            return student;
        }

        public Student GetStudentByName(string name)
        {
            string command = @"SELECT * FROM Students WHERE stu_name = @name";

            IDbParameters parameters = CreateDbParameters();
            parameters.Add("name", DbType.String).Value = name;

            IList<Student> student = ExecuteQueryWithRowMapper(command, parameters);
            if (student.Count > 0)
            {
                return student[0];
            }

            return null;
        }

        public Student GetStudentById(int id)
        {
            string command = @"SELECT * FROM Students WHERE id = @id";

            IDbParameters parameters = CreateDbParameters();
            parameters.Add("id", DbType.String).Value = id;

            IList<Student> student = ExecuteQueryWithRowMapper(command, parameters);
            if (student.Count > 0)
            {
                return student[0];
            }

            return null;
        }
    }
}
