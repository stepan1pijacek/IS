using IS.Data;
using IS.Interfaces;
using System;
using System.Linq;

namespace IS.CRUD
{
    public class Delete : IDelete
    {
        Read _Read = new Read();
        ISDbContext DbContext;

        public Delete()
        {
            ISDbContext _db = new ISDbContext();
            DbContext = _db;
        }

        public bool DeleteStudent(int studentID)
        {
            try
            {
                var select = DbContext.Students.FirstOrDefault(x => x.Id.Equals(studentID));
                DbContext.Remove(select);
                DbContext.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message.ToString());
            }
        }

        public bool DeleteFaculty(int facultyId)
        {
            try
            {
                DbContext.Remove(DbContext.Faculties.FirstOrDefault(x => x.Id.Equals(facultyId)));
                DbContext.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message.ToString());
            }
        }

        public bool DeleteSubject(int subjectID)
        {
            try
            {
                DbContext.Remove(DbContext.Subjects.FirstOrDefault(x => x.Id.Equals(subjectID)));
                DbContext.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message.ToString());
            }
        }

        public bool DeleteScoreByStudent(int studentID)
        {
            try
            {
                DbContext.Remove(DbContext.Scores.FirstOrDefault(x => x.StudentsId.Equals(studentID)));
                DbContext.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message.ToString());
            }
        }

        public bool DeleteScore(int scoreID)
        {
            try
            {
                DbContext.Remove(DbContext.Scores.FirstOrDefault(x => x.Id.Equals(scoreID)));
                DbContext.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message.ToString());
            }
        }
    }
}
