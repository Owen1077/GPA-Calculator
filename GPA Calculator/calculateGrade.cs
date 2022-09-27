using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GPA_Calculator
{
    internal class calculateGrade
    {
        public static void calculcateStudentGrade()
        {
            int totalCourses;
            pointzero:
            Console.WriteLine("How many courses did you offer?");


            while (!int.TryParse(Console.ReadLine(), out totalCourses))
            {

                Console.WriteLine("Enter intergers only");
            }
            if(totalCourses <= 0)
            {
                Console.WriteLine("Enter a valid number of courses");
                goto pointzero;
            }

            string courseName;
            int courseUnits;
            double score;
            string remark;
            string grade;
            int gradeUnit;
            int weightPoint;
            double totalWeightPoint = 0;
            int totalCourseUnit = 0;
            double gpa;
            int totalCourseUnitsPassed = 0;

            List<course> courseList = new List<course>();

            for (int i = 0; i < totalCourses; i++)
            {
                point0:
                Console.WriteLine($"\nPlease enter course code {i+1}");
                courseName = Console.ReadLine();
                foreach(var k in courseList)
                {
                    if(courseName == k.courseName)
                    {
                        Console.WriteLine("Don't repeat course codes");
                        goto point0;
                    }
                }
                var valid = new Regex(@"^([A-Za-z]{3} [0-9]{3})$");
                if (!valid.IsMatch(courseName))
                {
                    Console.WriteLine("Type a valid course code e.g: MTH 101");
                    goto point0;
                }


            point:
                Console.WriteLine("\nPlease enter the course unit");
                while (!int.TryParse(Console.ReadLine(), out courseUnits))
                {

                    Console.WriteLine("Enter intergers only");
                }
          

                if (courseUnits <= 0)
                {
                    Console.WriteLine("Please enter a valid unit");
                    goto point;
                }

            pointTwo:
                Console.WriteLine("\nPlease enter your score");

                while (!double.TryParse(Console.ReadLine(), out score))
                {

                    Console.WriteLine("Enter intergers only");
                }

                if (score > 100 || score < 0)
                {
                    Console.WriteLine("Please enter a score from 1 - 100");
                    goto pointTwo;
                }

                else if (score >= 70 && score <= 100)
                {
                    remark = "Excellent";
                    grade = "A";
                    gradeUnit = 5;
                }
                else if (score >= 60 && score <= 69)
                {
                    remark = "Very Good";
                    grade = "B";
                    gradeUnit = 4;
                }
                else if (score >= 50 && score <= 59)
                {
                    remark = "Good     ";
                    grade = "C";
                    gradeUnit = 3;
                }
                else if (score >= 45 && score <= 49)
                {
                    remark = "Fair     ";
                    grade = "D";
                    gradeUnit = 2;
                }
                else if (score >= 40 && score <= 44)
                {
                    remark = "Pass     ";
                    grade = "E";
                    gradeUnit = 1;
                }
                else
                {
                    remark = "Fail";
                    grade = "F";
                    gradeUnit = 0;
                }

                Console.WriteLine($"\nYour grade for this course is {grade}\n{remark}\n" +
                    "*********************************************************************\n");               
                if(grade != "F")
                {
                    totalCourseUnitsPassed += courseUnits;
                }
                weightPoint = courseUnits * gradeUnit;
                totalWeightPoint += weightPoint;
                totalCourseUnit += courseUnits;

                course courseConstructor = new course(courseName, courseUnits, score, remark, grade, gradeUnit, weightPoint);
               courseList.Add(courseConstructor);
            }

            gpa = totalWeightPoint/ totalCourseUnit;
            double newgpa = Math.Round(gpa, 2);
            
           
        PrintTable.PrintTableMethod(courseList);
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine($"Total Course Unit Registered is {totalCourseUnit}");
            Console.WriteLine($"\nTotal Course Unit Passed is {totalCourseUnitsPassed}");
            Console.WriteLine($"\nTotal Weight Point is {totalWeightPoint}");

            if (gpa % 1 == 0)
            {
                string newgpas = string.Format("{0:0.00}", gpa);
                Console.WriteLine($"\nYour GPA is = {newgpas}");
            }
            else
            {
                Console.WriteLine($"\nYour GPA is = {newgpa}");
            }
            Console.WriteLine("\nGoodbye!\n");
           
        }
    }
}
