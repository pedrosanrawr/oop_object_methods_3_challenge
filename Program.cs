using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace oop_object_methods_3_challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //class instatiation
            Student s = new Student();

            //introduceSelf output
            Console.WriteLine("Student Information");
            Console.WriteLine(s.introduceSelf());

            //evaluateGrade output
            Console.WriteLine("Grades");
            Console.WriteLine(s.evaluateGrade());
        }

        //class
        class Student
        {
            //attributes
            string firstName, lastName, course, section;
            int year;
            double midtermGrade, finalGrade;

            //constructor
            public Student()
             {
                //user input
                Console.Write("Enter first name: ");
                firstName = Console.ReadLine();
                Console.Write("Enter last name: ");
                lastName = Console.ReadLine();
                Console.Write("Enter course: ");
                course = Console.ReadLine();
                Console.Write("Enter section: ");
                section = Console.ReadLine();
                Console.Write("Enter year level: ");
                year = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter midterm grade: ");
                midtermGrade = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter final grade: ");
                finalGrade = Convert.ToDouble(Console.ReadLine());
            } 

            //method - introduceSelf
            public string introduceSelf()
            {
                string fullName = firstName + " " + lastName;

                return "His/Her name is " + fullName + ". His/Her course is " +
                    course + " batch " + year + " section " + section;
            }

            //method - evaluateGrade
            public string evaluateGrade()
            {
                double avgGrade = (midtermGrade + finalGrade) / 2;

                string evaluation = $"Midterm grade: {midtermGrade}\n" +
                               $"Final grade: {finalGrade}\n" +
                               $"GWA: {avgGrade}\n";

                if (avgGrade >= 98 && avgGrade <= 100)
                {
                    evaluation += "With highest honor";
                }
                else if (avgGrade >= 95 && avgGrade < 98)
                {
                    evaluation += "With high honor";
                }
                else if (avgGrade >= 90 && avgGrade < 95)
                {
                    evaluation += "With honor";
                }
                else if (avgGrade >= 75 && avgGrade < 90)
                {
                    evaluation += "Passed";
                }
                else
                {
                    evaluation += "Failed";
                }

                return evaluation;
            }
        }
    }
}
