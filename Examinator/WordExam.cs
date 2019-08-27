using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xceed.Words.NET;

namespace Examinator
{
    public class WordExam : Exam
    {
        public override void Generate()
        {
            var doc = DocX.Load(@".\templates\exam_template.docx");

            var template = DocX.Load(@"C:\stuff\list_template.docx");
            var questionTemplate = template.Lists.First();
            var answersTemplate = template.Tables.First();

            Console.WriteLine("Question? " + Questions.Count);
            foreach (var question in Questions)
            {
                if (questionTemplate.Items.First().Text.Length > 0)
                {
                    questionTemplate.Items.First().RemoveText(0);
                }
                questionTemplate.Items.First().InsertText(question.Text);
                doc.InsertList(questionTemplate);

                for (int i = 0; i < question.Answers.Count(); i++)
                {
                    answersTemplate.Rows[i].Cells[2].RemoveParagraphAt(0);
                    answersTemplate.Rows[i].Cells[2].InsertParagraph(question.Answers[i].Text);
                }
                doc.InsertTable(answersTemplate);
                doc.InsertParagraph("");
            }

            doc.SaveAs(@".\exam.docx");
        }
    }
}
