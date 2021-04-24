using System;
using IS.View;
using System.Windows;
using System.Windows.Input;

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

            MWviewModel model = new MWviewModel();

            NoOfStudents.Text = model.getStudents();
            NoOfFaculty.Text = model.getFaculties();
            Average.Text = model.getAVG();
            //GetStudent();
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

        }

        private void Table_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
