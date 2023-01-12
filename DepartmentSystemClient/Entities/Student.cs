using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentSystemClient.Entities
{
    public class Student
    {
        public int id { get; set; }
        public string? name { get; set; }
        public int department_id { get; set; }
        public int graduate_id { get; set; }
    }
}
