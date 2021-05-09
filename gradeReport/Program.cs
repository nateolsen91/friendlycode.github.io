using System;
using static System.Console;
namespace GradeReportFinal
{
    class Grade
    {
        static void Main(string[] args)
        {
            Grade[] reportArray = new Grade[3];
            int x;
            for (x = 0; x < reportArray.Length; ++x)
            {
                
                reportArray[x] = new Grade();

               
            }


            const int EXIT = 999;
            string name; //John, Bree, Danielle
            double midtermExam;
            double average;
            double finalExamGrade;
            string letterGrade;
            bool isAccepted = false;
            const double HIGH = 100;
            const double LOW = 0;

            Write("Enter the student's name or 999 to exit: ");
            name = ReadLine();
            for(x = 0; x < reportArray.Length; ++x)
            {
                try
                {
                   
                    Write("Enter your midterm grade: ");
                    midtermExam = Convert.ToDouble(ReadLine());
                    Write("Enter your final exam grade: ");
                    finalExamGrade = Convert.ToDouble(ReadLine());
                    average = (finalExamGrade + midtermExam) / 2;


                    WriteLine("Grade report for {0} is \n{1}: ", name, average);
                   
                    //double average = Convert.ToString(ReadLine());

                }
                catch(FormatException e)
                {

                    Write(e.Message + "\n");
;                   
                }
                catch(ArgumentException e)
                {
                    Write("The value must be between 0 and 100\n");
                }
                
                
            }
            

           


        }

        //static void GetData(out string Name, out double MidTermExam, out double FinalExamGrade, out string LetterGrade, out double Average)
        //{
        //    Name = null;
        //    MidTermExam = 0;
        //    FinalExamGrade = 0;
        //    LetterGrade = null;
        //    Average = 0;

        //    Write("Enter the student's name or 999 to exit: ");
        //    Name = ReadLine();
        //    Write("Enter your midterm exam grade or 999 to exit: ");
        //    MidTermExam = Convert.ToDouble(ReadLine());
        //    Write("Enter your final exam grade or 999 to exit: ");
        //    FinalExamGrade = Convert.ToDouble(ReadLine());
        //    Average = FinalExamGrade / MidTermExam;


        //    WriteLine();
        //}

        class ReportCard
        {
            public const double HIGH = 100;
            public const double LOW = 0;
            public string Name { get; set; }
            public double MidTermExam { get; set; }
            public double FinalExamGrade { get; set; }
            public string LetterGrade { get; set; }
            public double Average { get; set; }


            public ReportCard(string name, double midTermExam, double finalExamGrade, double average, string letterGrade)
            {
                Name = name;
                MidTermExam = midTermExam;
                FinalExamGrade = finalExamGrade;
                Average = average;
                LetterGrade = letterGrade;

            }

        }

    }
}
