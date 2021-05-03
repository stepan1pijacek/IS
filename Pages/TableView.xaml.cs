using IS.CRUD;
using IS.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace IS.Pages
{
    /// <summary>
    /// Interaction logic for TableView.xaml
    /// </summary>
    public partial class TableView : Window
    {
        Read _Read = new Read();
        Delete _Delete = new Delete();
        public TableView()
        {
            InitializeComponent();
            try
            {
                studentsView.ItemsSource = _Read.students().ToList();
                facultyView.ItemsSource = _Read.faculties().ToList();
                SubjectView.ItemsSource = _Read.subjects().ToList();
                ScoreView.ItemsSource = _Read.scores().ToList();
                StudentScoreView.ItemsSource = _Read.studentsScore();
                StudentFacultyView.ItemsSource = _Read.studentsFaculty();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void studentsView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TitleBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        private void Min_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Max_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState is WindowState.Maximized)
            {
                this.WindowState = WindowState.Normal;
            }
            else
            {
                this.WindowState = WindowState.Maximized;
            }
        }

        private void PowerOff_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            AddNew add = new AddNew();
            add.Show();
            this.Close();
        }

        private void Table_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Statistic_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Faculties_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Configuration_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EditStudent_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteStudent_Click(object sender, RoutedEventArgs e)
        {
            List<char> selectedItem = new List<char>();
            var student = studentsView.SelectedItems.OfType<Student>().ToList();
            int id = 0;
            try
            {
                foreach(var item in student)
                {
                    id = item.Id;
                }
                _Delete.DeleteStudent(id);
                studentsView.Items.RemoveAt(studentsView.SelectedIndex);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void EditFaculty_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteFaculty_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EditSubject_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteSubject_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EditScore_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteScore_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
