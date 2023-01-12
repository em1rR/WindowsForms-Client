using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentSystemClient.Filter
{
    public class StudentFilter
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DepartmentId { get; set; }
        public int GraduateId { get; set; }
        public byte Gender { get; set; }
    }
}
