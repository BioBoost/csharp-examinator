using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examinator
{
    public class Course
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private List<Question> questions = new List<Question>();
        public List<Question> Questions
        {
            get { return questions; }
            set { questions = value; }
        }

    }
}
