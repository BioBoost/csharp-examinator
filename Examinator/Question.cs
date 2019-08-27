using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examinator
{
    public class Question
    {
        public Question(string text)
        {
            Text = text;
        }

        public Question(int id, string text)
        {
            Id = id;
            Text = text;
        }

        public void AddAnswer(Answer answer)
        {
            answers.Add(answer);
        }

        private string text;
        public string Text
        {
            get { return text; }
            set { text = value; }
        }

        private List<Answer> answers = new List<Answer>();
        public List<Answer> Answers
        {
            get { return answers; }
            set { answers = value; }
        }

        private int id = -1;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private Course course;
        public Course Course
        {
            get { return course; }
            set { course = value; }
        }

    }
}
