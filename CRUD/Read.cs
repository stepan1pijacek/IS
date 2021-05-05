using IS.Data;
using IS.Interfaces;
using IS.Helper;
using IS.Pages;
using System.Collections.Generic;
using System.Linq;

namespace IS.CRUD
{
    public class Read : IRead
    {
        ISDbContext DbContext;
        public Read()
        {
            ISDbContext _db = new ISDbContext();
            DbContext = _db;
        }

        public List<Student> students()
        {
            List<Student> listOfStudents = DbContext.Students.ToList();
            return listOfStudents;
        }

        public List<Subject> subjects()
        {
            List<Subject> listOfSubjects = DbContext.Subjects.ToList();
            return listOfSubjects;
        }

        public List<Faculty> faculties()
        {
            List<Faculty> listOfFaculties = DbContext.Faculties.ToList();
            return listOfFaculties;
        }

        public List<Score> scores()
        {
            List<Score> listOfScores = DbContext.Scores.ToList();
            return listOfScores;
        }

        public List<object> studentsScore()
        {
            var selectedList = (from st in DbContext.Scores
                                     select new
                                     {
                                         StudentId = st.Students.Id,
                                         StudentName = st.Students.Name,
                                         StudentSurname = st.Students.Surname,
                                         FacultyName = st.Students.Faculty.FacultyName,
                                         Subject = st.Subject.SubjectName,
                                         StudentScore = st.Score1,
                                     }).ToList();
            //var resultSet = CreateList(selectedList);
            var finalEntries = new List<object>();
            finalEntries.AddRange(selectedList);
            return finalEntries;
        }

        public List<object> studentsFaculty()
        {
            var selectedList = (from sf in DbContext.Students
                                  select new
                                  {
                                      StudentId = sf.Id,
                                      StudentName = sf.Name,
                                      StudentSurname = sf.Surname,
                                      FacultyID = sf.Faculty.Id,
                                      FacultyName = sf.Faculty.FacultyName
                                  });
            var finalEntries = new List<object>();
            finalEntries.AddRange(selectedList);
            return finalEntries;
        }

        public List<object> studentsAVGperYear()
        {
            var selectedList = (from st in DbContext.Scores.Where(x => x.StudentsId == x.Students.Id)
                                select new
                                {
                                    Year = st.Students.Year,
                                    Score = st.Score1
                                }).ToList().GroupBy(x => x.Year);
            var finalEntries = new List<object>();
            finalEntries.AddRange(selectedList);
            return finalEntries;
        }
    }
}
