using DepartmentSystemClient.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentSystemClient.DTO
{
    public class StudentDTO
    {
        public int id { get; set; }
        public string? name { get; set; }
        public int department_id { get; set; }
        public string departmentName { get; set; }
        public int graduate_id { get; set; }
        public string graduateName { get; set; }
        public string gender { get; set; }
    }
}
