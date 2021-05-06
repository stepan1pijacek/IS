using IS.Data;

namespace IS.Interfaces
{
    interface IUpdate
    {
        bool UpdateStudent(Student student);
        bool UpdateFaculty(Faculty faculty);
        bool UpdateSubject(Subject subject);
        bool UpdateScore(Score score);
    }
}
