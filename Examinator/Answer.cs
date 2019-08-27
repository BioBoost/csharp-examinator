using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examinator
{
    public class Answer
    {
        public Answer(string text)
            : this(text, false)
        {
        }

        public Answer(string text, bool isCorrect)
        {
            Text = text;
            IsCorrect = isCorrect;
        }

        private bool isCorrect;
        public bool IsCorrect
        {
            get { return isCorrect; }
            set { isCorrect = value; }
        }

        private string text;
        public string Text
        {
            get { return text; }
            set { text = value; }
        }
    }
}
