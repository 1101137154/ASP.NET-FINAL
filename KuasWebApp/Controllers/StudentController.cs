using KuasCore.Models;
using KuasCore.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;

namespace KuasWebApp.Controllers
{
    public class StudentController : ApiController
    {

        public IStudentService StudentService { get; set; }

        [HttpPost]
        public Student AddStudent(Student student)
        {
            CheckStudentIsNotNullThrowException(student);

            try
            {
                return StudentService.AddStudent(student);
            }
            catch (Exception)
            {
                throw new HttpResponseException(HttpStatusCode.InternalServerError);
            }
        }

        [HttpPut]
        public Student UpdateStudent(Student student)
        {
            CheckStudentIsNullThrowException(student);
            
            try
            {
                StudentService.UpdateStudent(student);
                return StudentService.GetStudentByName(student.stu_name);
            }
            catch (Exception)
            {
                throw new HttpResponseException(HttpStatusCode.InternalServerError);
            }
           
        }

        [HttpDelete]
        public void DeleteEmployee(Student student)
        {
            try
            {
                StudentService.DeleteStudent(student);
            }
            catch (Exception)
            {
                throw new HttpResponseException(HttpStatusCode.InternalServerError);
            }
        }

        [HttpGet]
        public IList<Student> GetAllStudent()
        {
            return StudentService.GetAllStudent();
        }

        [HttpGet]
        public Student GetStudentById(int id)
        {
            var student = StudentService.GetStudentById(id);

            if (student == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            return student;
        }

        [HttpGet]
        [ActionName("Name")]
        public Student GetStudentByName(string input)
        {
            var student = StudentService.GetStudentByName(input);

            if (student == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            return student;
        }

        /// <summary>
        ///     檢查課程資料是否存在，如果不存在則拋出錯誤.
        /// </summary>
        /// <param name="student">
        ///     課程資料.
        /// </param>
        private void CheckStudentIsNullThrowException(Student student)
        {
            Student dbStudent = StudentService.GetStudentById(student.id);

            if (dbStudent == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
        }

        /// <summary>
        ///     檢查課程資料是否存在，如果存在則拋出錯誤.
        /// </summary>
        /// <param name="student">
        ///     課程資料.
        /// </param>
        private void CheckStudentIsNotNullThrowException(Student student)
        {
            Student dbStudent = StudentService.GetStudentById(student.id);

            if (dbStudent != null)
            {
                throw new HttpResponseException(HttpStatusCode.Conflict);
            }
        }

    }
}