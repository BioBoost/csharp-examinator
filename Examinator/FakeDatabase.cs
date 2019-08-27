using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examinator
{
    public class FakeDatabase : Database
    {
        public override List<Course> GetAllCourses()
        {
            return new List<Course>
            {
                new Course {Name = "Object Oriented Programming" },
                new Course {Name = "Introdution to Programmin" },
                new Course {Name = "IoT Devices" }
            };
        }
    }
}
