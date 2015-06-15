using KuasCore.Models;
using Spring.Data.Generic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuasCore.Dao.Mapper
{
    class StudentRowMapper : IRowMapper<Student>
    {
        public Student MapRow(IDataReader dataReader, int rowNum)
        {
            Student target = new Student();

            target.id = dataReader.GetInt32(dataReader.GetOrdinal("id"));
            target.stu_id = dataReader.GetString(dataReader.GetOrdinal("stu_id"));
            target.stu_name = dataReader.GetString(dataReader.GetOrdinal("stu_name"));
            target.stu_phone = dataReader.GetString(dataReader.GetOrdinal("stu_phone"));
            target.stu_birth = dataReader.GetDateTime(dataReader.GetOrdinal("stu_birth"));
            target.stu_info = dataReader.GetString(dataReader.GetOrdinal("stu_info"));

            return target;
        }
    }
}
