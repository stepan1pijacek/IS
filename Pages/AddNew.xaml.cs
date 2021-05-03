using IS.CRUD;
using IS.Data;
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

        }

        private void CreateFaculty_Click(object sender, RoutedEventArgs e)
        {
            string faculty = FacultyNameAdd.Text;

            try
            {
                var createFaculty = new Faculty
                {
                    FacultyName = faculty
                };

                _Create.NewFaculty(createFaculty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + "Something went wrong");
            }
        }

        private void CreateSubject_Click(object sender, RoutedEventArgs e)
        {
            string subject = SubjectNameAdd.Text;

            try
            {
                var createSubject = new Subject
                {
                    SubjectName = subject
                };

                _Create.NewSubject(createSubject);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + "Something went wrong");
            }
        }

        private void CreateScore_Click(object sender, RoutedEventArgs e)
        {
            string studentName = ScoreStudentName.Text.ToLower().Trim();
            string subjectName = ScoreSubject.Text.ToLower().Trim();
            int score = Convert.ToInt32(Score.Text.Trim());
            int studentId = 0;
            int subjectId = 0;


            try
            {
                var selectStudent = _Read.students().Where(x => x.Name.ToLower().Equals(studentName)).Select(x => x.Id);
                studentId = Convert.ToInt32(selectStudent);

                var selectSubject = _Read.subjects().Where(x => x.SubjectName.ToLower().Equals(subjectName)).Select(x => x.Id);
                subjectId = Convert.ToInt32(selectSubject);

                var createScore = new Score
                {
                    StudentsId = studentId,
                    SubjectId = subjectId,
                    Score1 = score
                };

                _Create.NewScore(createScore);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + "Something went wrong!");
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
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + "Something went wrong!");
            }
        }
    }
}
