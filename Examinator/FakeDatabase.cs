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
            courses = new List<Course>
            {
                new Course {Id = 1, Name = "Object Oriented Programming" },
                new Course {Id = 2, Name = "Introdution to Programmin" },
                new Course {Id = 3, Name = "IoT Devices" }
            };
            return courses;
        }

        public override Question CreateQuestion(Question question)
        {
            question.Id = lastQuestionId++;
            Course course = courses.Where(c => c.Id == question.Course.Id).First();
            course.Questions.Add(question);
            return question;
        }

        private int lastQuestionId = 0;
        private List<Course> courses;
    }
}
