using IS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Documents;

namespace IS.CRUD
{
    public class Read
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
            List<Subject> listOfSubjects = new List<Subject>();
            return listOfSubjects;
        }

        public List<Faculty> faculties()
        {
            List<Faculty> listOfFaculties = new List<Faculty>();
            return listOfFaculties;
        }

        public List<Score> scores()
        {
            List<Score> listOfScores = new List<Score>();
            return listOfScores;
        }

        public void studentsScore()
        {
            var studentsScoreList = (from st in DbContext.Scores
                                     select new
                                     {
                                        StudentId = st.Students.Id,
                                        StudentName = st.Students.Name,
                                        StudentSurname = st.Students.Surname,
                                        Subject = st.Subject.SubjectName,
                                        StudentScore = st.Score1
                                     }).ToList();
        }

        public void studentsFaculty()
        {
            var studentFaculty = (from sf in DbContext.Students
                                  select new
                                  {
                                      StudentId = sf.Id,
                                      StudentName = sf.Name,
                                      StudentSurname = sf.Surname,
                                      FacultyID = sf.Faculty.Id,
                                      FacultyName = sf.Faculty.FacultyName
                                  });
        }
    }
}
