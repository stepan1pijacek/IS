using System;
using IS.CRUD;
using IS.Pages;
using System.Windows;
using System.Windows.Input;
using System.Linq;

namespace IS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DateTime dateTime = new DateTime(2021, 5, 31);
            TimeSpan timeLeft = dateTime - DateTime.Now;
            isLeft.Text = timeLeft.Days.ToString();

            Read read = new Read();
            NoOfStudents.Text = read.students().Count.ToString();
            NoOfFaculty.Text = read.faculties().Count.ToString();
            Average.Text = read.scores().Average(x => x.Score1).ToString();
        }

        //private void GetStudent()
        //{
        //    StudentGD.ItemsSource = dbContext.Students.ToList();
        //}

        private void PowerOff_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void TitleBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
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

        private void Min_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            AddNew addNew = new AddNew();
            addNew.Show();
            this.Close();
        }

        private void Table_Click(object sender, RoutedEventArgs e)
        {
            TableView view = new TableView();
            view.Show();
            this.Close();
        }
    }
}
