namespace IS.Interfaces
{
    interface IDelete
    {
        bool DeleteStudent(int studentID);
        bool DeleteFaculty(int facultyId);
        bool DeleteSubject(int subjectID);
        bool DeleteScoreByStudent(int studentID);
        bool DeleteScore(int scoreID);
    }
}
