using IS.Data;

namespace IS.Interfaces
{
    interface ICreate
    {
        void NewStudent(Student studentNew);
        void NewFaculty(Faculty faculty);
        void NewSubject(Subject subject);
        void NewScore(Score score);
    }
}
