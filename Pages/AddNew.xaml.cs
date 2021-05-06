using IS.CRUD;
using IS.Data;
using Notifications.Wpf;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace IS.Pages
{
    /// <summary>
    /// Interaction logic for AddNew.xaml
    /// </summary>
    public partial class AddNew : Window
    {
        Create _Create = new Create();
        Read _Read = new Read();
        public AddNew()
        {
            InitializeComponent();
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
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Table_Click(object sender, RoutedEventArgs e)
        {
            TableView view = new TableView();
            view.Show();
            this.Close();
        }

        private void Faculties_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Statistic_Click(object sender, RoutedEventArgs e)
        {
            Statistics statistics = new Statistics();
            statistics.Show();
            this.Close();
        }

        private void CreateFaculty_Click(object sender, RoutedEventArgs e)
        {
            string faculty = FacultyNameAdd.Text;

            var notificationManager = new NotificationManager();

            try
            {
                var createFaculty = new Faculty
                {
                    FacultyName = faculty
                };

                _Create.NewFaculty(createFaculty);
                notificationManager.Show(new NotificationContent
                {
                    Title = "Operation completed",
                    Message = "Subject has been created succesfully!",
                    Type = NotificationType.Success
                });
            }
            catch (Exception ex)
            {
                notificationManager.Show(new NotificationContent
                {
                    Title = "Operation error",
                    Message = "Something went wrong!",
                    Type = NotificationType.Error
                });
            }
        }

        private void CreateSubject_Click(object sender, RoutedEventArgs e)
        {
            string subject = SubjectNameAdd.Text;

            var notificationManager = new NotificationManager();

            try
            {
                var createSubject = new Subject
                {
                    SubjectName = subject
                };

                _Create.NewSubject(createSubject);
                notificationManager.Show(new NotificationContent
                {
                    Title = "Operation completed",
                    Message = "Subject has been created succesfully!",
                    Type = NotificationType.Success
                });
            }
            catch (Exception ex)
            {
                notificationManager.Show(new NotificationContent
                {
                    Title = "Operation error",
                    Message = "Something went wrong!",
                    Type = NotificationType.Error
                });
            }
        }

        private void CreateScore_Click(object sender, RoutedEventArgs e)
        {
            string studentName = ScoreStudentName.Text.ToLower().Trim();
            string subjectName = ScoreSubject.Text.ToLower().Trim();
            int score = Convert.ToInt32(Score.Text.Trim());
            int studentId = 0;
            int subjectId = 0;

            var notificationManager = new NotificationManager();
            try
            {
                var selectStudent = _Read.students().FirstOrDefault(x => x.Name.ToLower().Trim() == studentName);
                studentId = Convert.ToInt32(selectStudent.Id);

                var selectSubject = _Read.subjects().FirstOrDefault(x => x.SubjectName.ToLower().Trim() == subjectName);
                subjectId = Convert.ToInt32(selectSubject.Id);

                var createScore = new Score
                {
                    StudentsId = studentId,
                    SubjectId = subjectId,
                    Score1 = score
                };

                _Create.NewScore(createScore);
                notificationManager.Show(new NotificationContent
                {
                    Title = "Operation completed",
                    Message = "Score has been created succesfully!",
                    Type = NotificationType.Success
                });
            }
            catch (Exception ex)
            {
                notificationManager.Show(new NotificationContent
                {
                    Title = "Operation error",
                    Message = "Something went wrong!",
                    Type = NotificationType.Error
                });
            }

        }

        private void CreateStudent_Click(object sender, RoutedEventArgs e)
        {
            string name = StudentsName.Text.Trim();
            string surname = StudentsSurname.Text.Trim();
            string email = Email.Text.Trim();
            int phone = Convert.ToInt32(Phone.Text.Trim());
            int year = Convert.ToInt32(Year.Text.Trim());
            DateTime birth = Convert.ToDateTime(DateOfBirth.Text.Trim());
            string faculty = FacultyName.Text.ToLower().Trim();
            int facultyId = 0;

            var notificationManager = new NotificationManager();
            try
            {
                var select = _Read.faculties().FirstOrDefault(x => x.FacultyName.ToLower() == faculty);
                facultyId = select.Id;

                var createStudent = new Student
                {
                    Name = name,
                    Surname = surname,
                    Email = email,
                    Phone = phone,
                    Year = year,
                    DateOfBirth = birth,
                    FacultyId = facultyId
                };

                _Create.NewStudent(createStudent);
                notificationManager.Show(new NotificationContent
                {
                    Title = "Operation completed",
                    Message = "Student has been created succesfully!",
                    Type = NotificationType.Success
                });

            }
            catch (Exception ex)
            {
                notificationManager.Show(new NotificationContent
                {
                    Title = "Operation error",
                    Message = "Something went wrong!",
                    Type = NotificationType.Error
                });
            }
        }
    }
}
