using IS.CRUD;
using IS.Pages;
using System;
using System.Linq;
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

            Read read = new Read();
            NoOfStudents.Text = read.students().Count.ToString();
            NoOfFaculty.Text = read.faculties().Count.ToString();
            Average.Text = Math.Round(Convert.ToDecimal(read.scores().Average(x => x.Score1)), 2).ToString();
            read.studentsAVGperYear();
        }

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

        private void Statistic_Click(object sender, RoutedEventArgs e)
        {
            Statistics statistics = new Statistics();
            statistics.Show();
            this.Close();
        }
    }
}
