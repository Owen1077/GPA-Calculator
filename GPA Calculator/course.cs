using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPA_Calculator
{
    public class course
    {
        public string courseName { get; set; }       
        public int courseUnits { get; }   
        public double score { get; }
        public string remark { get; }
        public string grade { get; }
        public int gradeUnit { get; }
        public int weightPoint { get; }

        public course(string courseName, int courseUnits, double score, 
            string remark, string grade, int gradeUnit,int weightPoint)
        {
            this.courseName = courseName;
            this.courseUnits = courseUnits;
            this.score = score;
            this.remark = remark;
            this.grade = grade;
            this.gradeUnit = gradeUnit;
            this.weightPoint = weightPoint;
        }

       
    }
}
