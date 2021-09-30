using System;
using System.Collections.Generic;
using System.Text;

namespace CrudProject
{
    class Student
    {

        public String Name { get; set; }
        public String Reg { get; set; }
        public String Class { get; set; }
        public String Section { get; set; }

        public Student(string name, string reg, string @class, string section)
        {
            Name = name;
            Reg = reg;
            Class = @class;
            Section = section;
        }
    }
}
