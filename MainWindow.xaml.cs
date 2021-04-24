using IS.Data;
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

namespace IS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ISDbContext dbContext;
        public MainWindow(ISDbContext dbContext)
        {
            this.dbContext = dbContext;
            InitializeComponent();
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
