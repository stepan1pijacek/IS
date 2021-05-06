using IS.CRUD;
using IS.Data;
using Notifications.Wpf;
using System;
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
        Update _Update = new Update();
        NotificationManager notificationManager = new NotificationManager();
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
            var student = studentsView.SelectedItems.OfType<Student>().ToList();
            try
            {
                Student updateStudent = new Student();

                foreach (var x in student)
                {
                    updateStudent.Id = x.Id;
                    updateStudent.Name = x.Name;
                    updateStudent.Surname = x.Surname;
                    updateStudent.DateOfBirth = x.DateOfBirth;
                    updateStudent.Email = x.Email;
                    updateStudent.Phone = x.Phone;
                    updateStudent.Year = x.Year;
                    updateStudent.FacultyId = x.FacultyId;
                }

                _Update.UpdateStudent(updateStudent);
                studentsView.Items.Refresh();
                notificationManager.Show(new NotificationContent
                {
                    Title = "Operation completed",
                    Message = "Student has been updated succesfully!",
                    Type = NotificationType.Information
                });
            }
            catch
            {
                notificationManager.Show(new NotificationContent
                {
                    Title = "Operation error",
                    Message = "Something went wrong!",
                    Type = NotificationType.Error
                });
            }
        }

        private void DeleteStudent_Click(object sender, RoutedEventArgs e)
        {
            var student = studentsView.SelectedItems.OfType<Student>().ToList();
            int id = 0;
            try
            {
                foreach (var item in student)
                {
                    id = item.Id;
                }
                _Delete.DeleteStudent(id);
                studentsView.Items.Refresh();
                notificationManager.Show(new NotificationContent
                {
                    Title = "Operation completed",
                    Message = "Student has been deleted succesfully!",
                    Type = NotificationType.Warning
                });
            }
            catch
            {
                notificationManager.Show(new NotificationContent
                {
                    Title = "Operation error",
                    Message = "Something went wrong!",
                    Type = NotificationType.Error
                });
            }
        }

        private void EditFaculty_Click(object sender, RoutedEventArgs e)
        {
            var faculty = facultyView.SelectedItems.OfType<Faculty>().ToList();
            try
            {
                Faculty updateFaculty = new Faculty();

                foreach (var x in faculty)
                {
                    updateFaculty.Id = x.Id;
                    updateFaculty.FacultyName = x.FacultyName;
                }

                _Update.UpdateFaculty(updateFaculty);
                facultyView.Items.Refresh();
                notificationManager.Show(new NotificationContent
                {
                    Title = "Operation completed",
                    Message = "Faculty has been updated succesfully!",
                    Type = NotificationType.Information
                });
            }
            catch
            {
                notificationManager.Show(new NotificationContent
                {
                    Title = "Operation error",
                    Message = "Something went wrong!",
                    Type = NotificationType.Error
                });
            }
        }

        private void DeleteFaculty_Click(object sender, RoutedEventArgs e)
        {
            var faculty = facultyView.SelectedItems.OfType<Faculty>().ToList();
            int id = 0;
            try
            {
                foreach (var item in faculty)
                {
                    id = item.Id;
                }
                _Delete.DeleteFaculty(id);
                facultyView.Items.Refresh();
                notificationManager.Show(new NotificationContent
                {
                    Title = "Operation completed",
                    Message = "Faculty has been deleted succesfully!",
                    Type = NotificationType.Warning
                });
            }
            catch
            {
                notificationManager.Show(new NotificationContent
                {
                    Title = "Operation error",
                    Message = "Something went wrong!",
                    Type = NotificationType.Error
                });
            }
        }

        private void EditSubject_Click(object sender, RoutedEventArgs e)
        {
            var subject = SubjectView.SelectedItems.OfType<Subject>().ToList();
            try
            {
                Subject updateSubject = new Subject();

                foreach (var x in subject)
                {
                    updateSubject.Id = x.Id;
                    updateSubject.SubjectName = x.SubjectName;
                }

                _Update.UpdateSubject(updateSubject);
                SubjectView.Items.Refresh();
                notificationManager.Show(new NotificationContent
                {
                    Title = "Operation completed",
                    Message = "Subject has been updated succesfully!",
                    Type = NotificationType.Information
                });
            }
            catch
            {
                notificationManager.Show(new NotificationContent
                {
                    Title = "Operation error",
                    Message = "Something went wrong!",
                    Type = NotificationType.Error
                });
            }
        }

        private void DeleteSubject_Click(object sender, RoutedEventArgs e)
        {
            var subject = SubjectView.SelectedItems.OfType<Subject>().ToList();
            int id = 0;
            try
            {
                foreach (var item in subject)
                {
                    id = item.Id;
                }
                _Delete.DeleteSubject(id);
                SubjectView.Items.Refresh();
                notificationManager.Show(new NotificationContent
                {
                    Title = "Operation completed",
                    Message = "Subject has been deleted succesfully!",
                    Type = NotificationType.Warning
                });
            }
            catch
            {
                notificationManager.Show(new NotificationContent
                {
                    Title = "Operation error",
                    Message = "Something went wrong!",
                    Type = NotificationType.Error
                });
            }
        }

        private void EditScore_Click(object sender, RoutedEventArgs e)
        {
            var score = ScoreView.SelectedItems.OfType<Score>().ToList();
            try
            {
                Score updateScore = new Score();

                foreach (var x in score)
                {
                    updateScore.Id = x.Id;
                    updateScore.StudentsId = x.StudentsId;
                    updateScore.SubjectId = x.SubjectId;
                    updateScore.Score1 = x.Score1;
                }

                _Update.UpdateScore(updateScore);
                ScoreView.Items.Refresh();
                notificationManager.Show(new NotificationContent
                {
                    Title = "Operation completed",
                    Message = "Score has been updated succesfully!",
                    Type = NotificationType.Information
                });
            }
            catch
            {
                notificationManager.Show(new NotificationContent
                {
                    Title = "Operation error",
                    Message = "Something went wrong!",
                    Type = NotificationType.Error
                });
            }
        }

        private void DeleteScore_Click(object sender, RoutedEventArgs e)
        {
            var score = ScoreView.SelectedItems.OfType<Score>().ToList();
            int id = 0;
            try
            {
                foreach (var item in score)
                {
                    id = item.Id;
                }
                _Delete.DeleteScore(id);
                ScoreView.Items.Refresh();
                notificationManager.Show(new NotificationContent
                {
                    Title = "Operation completed",
                    Message = "Score has been deleted succesfully!",
                    Type = NotificationType.Warning
                });
            }
            catch
            {
                notificationManager.Show(new NotificationContent
                {
                    Title = "Operation error",
                    Message = "Something went wrong!",
                    Type = NotificationType.Error
                });
            }
        }

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
            SubjectView.Items.Refresh();
            ScoreView.Items.Refresh();
            StudentFacultyView.Items.Refresh();
            StudentScoreView.Items.Refresh();
            studentsView.Items.Refresh();
            facultyView.Items.Refresh();
            SubjectView.Items.Refresh();
        }
    }
}
