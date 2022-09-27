using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using ConsoleTables;


namespace GPA_Calculator
{
    public class PrintTable
    {
        public static void PrintTableMethod(List<course> courseList)
        {

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n|--------------|-----------|------|-----------|------------|------------|\n" +
                              "|COURSE & CODE |COURSE UNIT|GRADE |GRADE UNIT |GRADE POINT |REMARK      |\n" +
                              "|--------------|-----------|------|-----------|------------|------------|");
            foreach (var z in courseList)
            {
                Console.WriteLine($"|{(z.courseName).ToUpper()}       |{z.courseUnits}          |{z.grade}     |{z.gradeUnit}          |{z.weightPoint}           |{z.remark}  |");
            }
            Console.WriteLine("|--------------|-----------|------|-----------|------------|------------|");
        }
    }
}
