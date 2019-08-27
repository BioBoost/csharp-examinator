﻿using System;
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
    /// Interaction logic for ExamBuilderWindow.xaml
    /// </summary>
    public partial class ExamBuilderWindow : Window
    {
        public ExamBuilderWindow()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            CourseSelectorWindow window = new CourseSelectorWindow();
            window.Show();
            this.Close();
        }
    }
}
