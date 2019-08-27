using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examinator
{
    public abstract class Database
    {
        public abstract List<Course> GetAllCourses();
        public abstract Question CreateQuestion(Question question);
    }
}
