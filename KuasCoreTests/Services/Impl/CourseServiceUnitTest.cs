using Core;
using KuasCore.Models;
using KuasCore.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Spring.Context;
using Spring.Testing.Microsoft;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuasCoreTests.Services.Impl
{
    [TestClass]
    public class StudentServiceUnitTest : AbstractDependencyInjectionSpringContextTests
    {

        #region Spring 單元測試必寫的內容

        override protected string[] ConfigLocations
        {
            get
            {
                return new String[] { 
                    //assembly://MyAssembly/MyNamespace/ApplicationContext.xml
                    "~/Config/KuasCoreDatabase.xml",
                    "~/Config/KuasCorePointcut.xml",
                    "~/Config/KuasCoreTests.xml" 
                };
            }
        }

        #endregion

        public IStudentService StudentService { get; set; }

        [TestMethod]
        public void TestStudentService_AddStudent()
        {
            Student student = new Student();
            student.stu_id = "UnitTests";
            student.stu_name = "單元測試";
            student.stu_phone = "請做出單元測試";
            student.stu_birth = System.DateTime.Today;
            student.stu_info = "請做出單元測試";
            StudentService.AddStudent(student);

            Student dbStudent = StudentService.GetStudentByName(student.stu_name);
            Assert.IsNotNull(dbStudent);
            Assert.AreEqual(student.stu_name, dbStudent.stu_name);

            Console.WriteLine("課程編號為 = " + dbStudent.stu_id);
            Console.WriteLine("課程名稱為 = " + dbStudent.stu_name);
            Console.WriteLine("課程描述為 = " + dbStudent.stu_info);

            StudentService.DeleteStudent(dbStudent);
            dbStudent = StudentService.GetStudentByName(student.stu_name);
            Assert.IsNull(dbStudent);
        }

    }
}
