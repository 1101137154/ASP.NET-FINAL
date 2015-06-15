using KuasCore.Dao;
using KuasCore.Models;
using KuasCore.Services.Impl;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Spring.Testing.Microsoft;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuasCoreTests.Dao
{
    [TestClass]
    public class StudentDaoUnitTest : AbstractDependencyInjectionSpringContextTests
    {

        #region Spring 單元測試必寫的內容

        override protected string[] ConfigLocations
        {
            get
            {
                return new String[] { 
                    "~/Config/KuasCoreDatabase.xml",
                    "~/Config/KuasCorePointcut.xml",
                    "~/Config/KuasCoreTests.xml" 
                };
            }
        }

        #endregion

        public IStudentDao StudentDao { get; set; }


        [TestMethod]
        public void TestStudentDao_AddStudent()
        {
            Student student = new Student();
            student.Id = "UnitTests";
            student.Name = "單元測試";
            student.Description = "請做出單元測試";
            StudentDao.AddStudent(student);

            Student dbStudent = StudentDao.GetStudentByName(student.Name);
            Assert.IsNotNull(dbStudent);
            Assert.AreEqual(student.Name, dbStudent.Name);

            Console.WriteLine("課程編號為 = " + dbStudent.Id);
            Console.WriteLine("課程名稱為 = " + dbStudent.Name);
            Console.WriteLine("課程描述為 = " + dbStudent.Description);

            StudentDao.DeleteStudent(dbStudent);
            dbStudent = StudentDao.GetStudentByName(student.Name);
            Assert.IsNull(dbStudent);
        }

    }
}
