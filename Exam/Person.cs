using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Exam
    
{
    public  class Person
    {
        public string Name { get; set; }
        public string Major { get; set; }

        public Person(string name, string major)
        {
            Name = name;
            Major = major;
        }
    }

}
