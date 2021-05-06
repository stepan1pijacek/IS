
using IS.CRUD;
using IS.Helper;
using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace IS.Pages
{
    /// <summary>
    /// Interaction logic for Statistics.xaml
    /// </summary>
    public partial class Statistics : Window
    {
        public ChartValues<int> Average { get; set; }
        public string[] Years { get; set; }
        Read _Read = new Read();

        public Statistics()
        {
            InitializeComponent();
            getData();
        }

        public void getData()
        {
            IEnumerable<HelperGraphClass> resultSet = _Read.studentsAVGperYear();
            Average = new ChartValues<int>(resultSet.Select(x => x.Score));
            Years = resultSet.Select(x => x.Year.ToString()).ToArray();
        }

        private void TitleBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {

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

        }

        private void Faculties_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Configuration_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
