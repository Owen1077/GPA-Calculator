using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPA_Calculator
{
    internal class Program {
        static void Main(string[] args)
        {
            string studentName;
            Console.WriteLine("*********************************************************************");

            Console.WriteLine("Please enter your name");
            studentName = Console.ReadLine().ToUpper();
            Console.WriteLine($"WELCOME {studentName}!");

            Console.WriteLine("*********************************************************************");

            calculateGrade.calculcateStudentGrade();
        }  
    }
}
