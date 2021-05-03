using IS.Data;
using System;
using System.Linq;

namespace IS.CRUD
{
    public class Delete
    {
        ISDbContext DbContext;

        public Delete()
        {
            ISDbContext _db = new ISDbContext();
            DbContext = _db;
        }

        public void DeleteStudent(int studentID)
        {
            try
            {
                DbContext.Remove(DbContext.Students.SingleOrDefault(x => x.Id.Equals(studentID)));
                DbContext.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message.ToString());
            }
        }

        public void DeleteFaculty(int facultyId)
        {
            try
            {
                DbContext.Remove(DbContext.Faculties.SingleOrDefault(x => x.Id.Equals(facultyId)));
                DbContext.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message.ToString());
            }
        }

        public void DeleteScoreByStudent(int studentID)
        {
            try
            {
                DbContext.Remove(DbContext.Scores.SingleOrDefault(x => x.StudentsId.Equals(studentID)));
                DbContext.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message.ToString());
            }
        }

        public void DeleteScore(int scoreID)
        {
            try
            {
                DbContext.Remove(DbContext.Scores.SingleOrDefault(x => x.Id.Equals(scoreID)));
                DbContext.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message.ToString());
            }
        }
    }
}
