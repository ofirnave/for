using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleApp13
{
    internal class Program
    {

        static void Main(string[] args)


        {

            int countday;
            int daysteps;
            int countsteps = 0;
            int count10ksteps = 0;
            int i;

            Console.Write("how many days");
            countday = int.Parse(Console.ReadLine());

            for (i = 0; i <= countday; i++)
            {
                Console.WriteLine("how many steps you did");
                daysteps = int.Parse(Console.ReadLine());
                countsteps = countsteps + daysteps;

                if (daysteps > 10000)
                    count10ksteps++;
            }

            Console.Write("total steps: " + countsteps);

            Console.Write("days above 10k steps: " + count10ksteps);







            Console.WriteLine("how many students");
            int studentscount = int.Parse(Console.ReadLine());
            int averagegrade = 0;
            int maxgrade = 0;
            int grade;
            int studentspass = 0;
            int i;

            for (i = 0; i < studentscount; i++)
            {
                Console.WriteLine("enter grade");
                grade = int.Parse(Console.ReadLine());
                if (grade >= 55)
                    studentspass++;

               if (grade > maxgrade)
                    maxgrade = grade;
                averagegrade += grade;
            }
            Console.WriteLine(averagegrade / studentscount);
            Console.WriteLine(maxgrade);
            Console.WriteLine(studentspass);
        }



    }

}