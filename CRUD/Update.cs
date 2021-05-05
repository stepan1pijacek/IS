using IS.Data;
using IS.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IS.CRUD
{
    public class Update : IUpdate
    {
        ISDbContext DbContext;
        public Update()
        {
            ISDbContext _db = new ISDbContext();
            DbContext = _db;
        }

        public bool UpdateStudent(Student student)
        {
            Read read = new Read();
            var result = read.students().Where(x => x.Id.Equals(student.Id));

            if (result == null)
            {
                throw new Exception("Something went wrong!");
            }

            try
            {
                DbContext.Update(student);
                DbContext.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message.ToString());
            }
        }

        public bool UpdateFaculty(Faculty faculty)
        {
            Read read = new Read();
            var result = read.faculties().Where(x => x.Id.Equals(faculty.Id));

            if (result == null)
            {
                throw new Exception("Something went wrong!");
            }

            try
            {
                DbContext.Update(faculty);
                DbContext.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message.ToString());
            }
        }

        public bool UpdateSubject(Subject subject)
        {
            Read read = new Read();
            var result = read.subjects().Where(x => x.Id.Equals(subject.Id));

            if (result == null)
            {
                throw new Exception("Something went wrong!");
            }

            try
            {
                DbContext.Update(subject);
                DbContext.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message.ToString());
            }
        }

        public bool UpdateScore(Score score)
        {
            try
            {
                DbContext.Update(score);
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
