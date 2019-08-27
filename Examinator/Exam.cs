using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examinator
{
    public abstract class Exam
    {
        public List<Question> Questions { get; set; }
        public Course Course { get; set; }

        public abstract void Generate();
    }
}
