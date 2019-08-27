using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examinator
{
    public class FakeDatabase : Database
    {
        public override List<string> GetAllCourses()
        {
            return new List<string>
            {
                "Object Oriented Programming",
                "Introdution to Programmin",
                "IoT Devices"
            };
        }
    }
}
