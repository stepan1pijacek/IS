using IS.Data;
using IS.Interfaces;

namespace IS.CRUD
{
    public class Create : ICreate
    {
        ISDbContext DbContext;
        public Create()
        {
            ISDbContext _db = new ISDbContext();
            DbContext = _db;
        }

        public async void NewStudent(Student studentNew)
        {
            await DbContext.Students.AddAsync(studentNew);
            await DbContext.SaveChangesAsync();
        }

        public async void NewFaculty(Faculty faculty)
        {
            await DbContext.Faculties.AddAsync(faculty);
            await DbContext.SaveChangesAsync();
        }

        public async void NewSubject(Subject subject)
        {
            await DbContext.Subjects.AddAsync(subject);
            await DbContext.SaveChangesAsync();
        }

        public async void NewScore(Score score)
        {
            await DbContext.Scores.AddAsync(score);
            await DbContext.SaveChangesAsync();
        }
    }
}
