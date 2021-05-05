using IS.Data;
using System;
using System.Linq;

namespace IS.View
{
    public class MWviewModel
    {
        ISDbContext DbContext;
        public MWviewModel()
        {
            ISDbContext _db = new ISDbContext();
            DbContext = _db;
        }

        public string getStudents()
        {
            int count = DbContext.Students.Count();
            return count.ToString();
        }

        public string getFaculties()
        {
            int count = DbContext.Faculties.Count();
            return count.ToString();
        }

        public string getAVG()
        {
            double res;
            var select = DbContext.Scores.Select(o => o.Score1);
            res = (double)select.Average();
            Math.Round(res, 2);
            return res.ToString();
        }
    }
}
