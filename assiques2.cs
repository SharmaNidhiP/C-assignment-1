using System;

namespace assi1ques2
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter marks obtained in  sub1");
            int sub1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter marks obtained in  sub2");
            int sub2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter marks obtained in  sub3");
            int sub3 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter marks obtained in  sub4");
            int sub4 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter marks obtained in  sub5");
            int sub5 = int.Parse(Console.ReadLine());
            int avg = ((sub1+sub2+sub3+sub4+sub5)/5);
            Console.WriteLine("AVERAGE = "+avg);
            if (sub1>sub2 && sub1>sub3 && sub1>sub4 && sub1>sub5)
            {
                Console.WriteLine("Subject 1 is the highest");
            }
            else if (sub2>sub1 && sub2>sub3 && sub2>sub4 && sub2>sub5)
            {
                Console.WriteLine("Subject 2 is the highest");
            }
            else if (sub3>sub1 && sub3>sub2 && sub3>sub4 && sub3>sub5)
            {
                Console.WriteLine("Subject 3 is the highest");
            }
            else if (sub4>sub1 && sub4>sub2 && sub4>sub3 && sub4>sub5)
            {
                Console.WriteLine("Subject 4 is the highest");
            }
            else
            {
                Console.WriteLine("Subject 5 is the highest");
            }
        }
    }
}
