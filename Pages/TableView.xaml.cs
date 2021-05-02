using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using IS.CRUD;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace IS.Pages
{
    /// <summary>
    /// Interaction logic for TableView.xaml
    /// </summary>
    public partial class TableView : Window
    {
        Read _Read = new Read();
        public TableView()
        {
            InitializeComponent();
            try 
            { 
                var items = _Read.students();
                studentsView.ItemsSource = items;
            }
            catch(Exception ex)
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

        }

        private void Min_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Max_Click(object sender, RoutedEventArgs e)
        {

        }

        private void PowerOff_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {

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
    }
}
