using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Examinator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(Course course)
        {
            currentCourse = course;
            InitializeComponent();
            this.DataContext = currentCourse;
        }

        private Course currentCourse = new Course { Name = "unknown" };
        private Database database = new FakeDatabase();

        private void CreateQuestion_Click(object sender, RoutedEventArgs e)
        {
            Question question = new Question(questionText.Text);
            question.AddAnswer(new Answer(correctAnswer.Text, true));
            question.AddAnswer(new Answer(answer1.Text));
            question.AddAnswer(new Answer(answer2.Text));
            question.AddAnswer(new Answer(answer3.Text));
            database.CreateQuestion(question);
            Console.WriteLine("Question succesfully created with id = " + question.Id);
        }
    }
}
