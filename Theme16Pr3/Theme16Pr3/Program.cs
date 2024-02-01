using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme16Pr3
{
    
    class Program
    {
        static DateTime Print()
        {
            Console.Write("Day ");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.Write("Month ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Year ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            return new DateTime(year, month, day);
        }

        static void Main(string[] args)
        {
            //Task1 

            //Console.WriteLine("Day ");
            //int day = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Month ");
            //int month = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Year ");
            //int year = Convert.ToInt32(Console.ReadLine());
            //DateClass d1 = new DateClass(year,month,day);
            //d1.DayBeforeDay();
            //d1.DayAfterDay();
            //d1.DaysSum();

            //Task 2
            //DateTime date1 = Print();
            //DateTime date2 = Print();

            //TimeSpan t1 = date1 - date2;
            //Console.WriteLine($"{date1:d}\n {date2:d}\n days count {t1.Days}");


            //Task 3

            Console.WriteLine("1st procedure");
            TimeSpan proc1 = TimeSpan.Parse(Console.ReadLine());
            Console.WriteLine("2nd procedure");
            TimeSpan proc2 = TimeSpan.Parse(Console.ReadLine());
            Console.WriteLine("Procedure Count");
            int count = int.Parse(Console.ReadLine());
            Procedure procedure = new Procedure(proc1,proc2,count);

            procedure.Output();


            Console.ReadKey();
            
        }
    }
}
