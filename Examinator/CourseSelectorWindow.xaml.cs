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
using System.Windows.Shapes;

namespace Examinator
{
    /// <summary>
    /// Interaction logic for CourseSelectorWindow.xaml
    /// </summary>
    public partial class CourseSelectorWindow : Window
    {
        public CourseSelectorWindow()
        {
            InitializeComponent();
        }

        private void StartCreatingQuestions_Click(object sender, RoutedEventArgs e)
        {
            string courseName = courseSelection.Text;
            MainWindow window = new MainWindow(new Course { Name = courseName });
            window.Show();
            this.Close();
        }

        private void StartBuildingExam_Click(object sender, RoutedEventArgs e)
        {
            string courseName = courseSelection.Text;
            ExamBuilderWindow window = new ExamBuilderWindow();
            window.Show();
            this.Close();
        }
    }
}
