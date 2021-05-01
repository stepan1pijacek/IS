using IS.Data;
using IS.CRUD;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace IS.CRUD
{
    public class Update
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

            if(result == null)
            {
                throw new Exception("Something went wrong!");
            }

            try
            {
                result = (IEnumerable<Student>)student;
                DbContext.Update(result);
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

            if(result == null)
            {
                throw new Exception("Something went wrong!");
            }

            try
            {
                result = (IEnumerable<Faculty>)faculty;
                DbContext.Update(result);
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

            if(result == null)
            {
                throw new Exception("Something went wrong!");
            }

            try
            {
                result = (IEnumerable<Subject>)subject;
                DbContext.Update(result);
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
