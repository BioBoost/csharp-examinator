using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examinator
{
    public class FakeDatabase : Database
    {
        public FakeDatabase()
        {
            courses = new List<Course>
            {
                new Course {Id = 1, Name = "Object Oriented Programming" },
                new Course {Id = 2, Name = "Introdution to Programmin" },
                new Course {Id = 3, Name = "IoT Devices" }
            };

            CreateQuestion(new Question
            {
                Course = courses[0],
                Text = "Some fake question text",
                Answers = new List<Answer> {
                    new Answer("Just some answer"),
                    new Answer("Another answer"),
                    new Answer("Option C"),
                    new Answer("Last but not least")
                }
            });

            CreateQuestion(new Question
            {
                Course = courses[0],
                Text = "Just a second question to test",
                Answers = new List<Answer> {
                    new Answer("Ollllaaaa"),
                    new Answer("Polllaaaaa"),
                    new Answer("Marco"),
                    new Answer("Polo")
                }
            });
        }

        public override List<Course> GetAllCourses()
        {
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
        private List<Course> courses = new List<Course>();
    }
}
