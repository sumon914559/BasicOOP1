using System;

namespace UniversityApplication
{
    class Program
    {
        static void Main(string[] args)
        {
           

            // try
            // {
            //     University cityCollege = new University("dhaka city college");
            //     Department bba = new Department("bachalor of business", "bba");
            //     Department cse = new Department("computer sciece", "cse");
            //     Department law = new Department("computer sciece123", "law");
            //     cityCollege.AddDepartment(bba);
            //     cityCollege.AddDepartment(cse);
            //     cityCollege.AddDepartment(law);
            //
            //     
            // }
            // catch (Exception e)
            // {
            //     Console.WriteLine(e.Message);
            // }

            int number = 10;
            TestInfo aInfo = new TestInfo();
            aInfo.MyNumber = 60;

            ForNothing(aInfo, number);

            Console.WriteLine(number); // 100
            Console.WriteLine(aInfo.MyNumber); // 70
            Console.ReadKey();

        }

        private static void ForNothing(TestInfo aInfo, int number)
        {
            aInfo.MyNumber = 70;
            number = 100;
        }
    }
}
