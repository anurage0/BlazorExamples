using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorExamples_Models
{
    public class Employee
    {
        public int Id
        {
            get; set;
        }

        public string Name
        {
            get; set;
        }

        public string Department
        {
            get; set;
        }

        public List<Skill> Skills
        {
            get; set;
        }
    }
}
