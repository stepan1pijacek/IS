using IS.Data;
using System;
using System.Collections.Generic;
using System.Text;

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
