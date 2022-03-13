using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the 1st marks");
            int h=int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the 2nd marks");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the 3rd marks");
            int e=int.Parse(Console.ReadLine());

            int total=h+m+e;
            float per = total * 100 / 300;
            if (total >= 200)
            {
                Console.WriteLine("grade A");
            }
            else if (total >= 150)
            {
                Console.WriteLine("grade B");
            }
            else
            {
                Console.WriteLine("fail");
            }


            Console.WriteLine("1st marks:- {0} 2nd marks :- {1} 3rd marks:- {2} total:- {3} per:- {4}", h, m, e, total, per);

            Console.ReadLine();
        }
    }
}
