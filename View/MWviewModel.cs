using IS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IS.View
{
    public class MWviewModel
    {
        
        public MWviewModel()
        {
        }

        //public string getStudents()
        //{
        //    int count;
        //    using(var dbContext = new ISDbContext()) 
        //    { 
        //        count = dbContext.Students.Count();
        //    }
        //    return count.ToString();
        //}

        //public string getFaculties()
        //{
        //    int count;
        //    using (var dbContext = new ISDbContext())
        //    {
        //        count = dbContext.Faculties.Count();
        //    }
        //    return count.ToString();
        //}

        //public string getAVG()
        //{
        //    double res;
        //    using (var dbContext = new ISDbContext())
        //    {
        //        var select = dbContext.Scores.Select(o => o.Score1);
        //        res = (double)select.Average();
        //    }
        //    return res.ToString();
        //}
    }
}
