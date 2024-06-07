using System;
using System.Linq;

namespace SLU1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Q2.1
            /*
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            if (n1 == n2)
            {
                Console.WriteLine(3 * (n1 * n2));

            }
            else
            {
                Console.WriteLine(n1 * n2);
            }
            
            //Q1.3
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            if (n1 + n2 == 30 || n1 == 30 || n2 == 30)
            {
                Console.WriteLine("true");
            }
            else
                Console.WriteLine("False");


            //Q1.2
            int n = int.Parse(Console.ReadLine());
            if (n > 51)
                Console.WriteLine(3 * (n - 51));
            else
                Console.WriteLine(51 - n);
            

            //Q1.5

            string s = Console.ReadLine();
            if (s[0]=='i'&&s[1]=='f')
                Console.WriteLine(s);
            else
            {
                s = "if " + s;
                Console.WriteLine(s);
            }
                        //Q1.6
            string s = Console.ReadLine();

            int po = int.Parse(Console.ReadLine());
            string news = s.Remove(po, 1);
            Console.WriteLine(news);
            
                      //Q1.7

            string s = Console.ReadLine();
            if (s.Length < 2)
                Console.WriteLine(s);
            else
            {
                string news = s.Substring(0, 2);
                for (int i = 0; i < 4; i++)
                    Console.Write(news);

            }
            
            //Q1.11

            string s = Console.ReadLine();
            int i = 0;
            string m = "";
            while (i < 3 && i < s.Length) m += s[i++];
            s = m + s + m;
            Console.WriteLine(s);
            

            // Q1.12

            string s = Console.ReadLine();
            int i = 0;
            string m = "";
            while (i < 2 && i < s.Length) m += s[i++];
            if (m == "C#") Console.WriteLine("true");
            else Console.WriteLine("false");
            */

            //String s = Console.ReadLine();



            //char f = s[0];
            //char l = s[s.Length -1];
            //char tem = f;
            //String news="";
            //for (int i = 1; i < s.Length - 1; i++)
            //{
            //    news+= s[i];

            //}
            //Console.WriteLine(l+news+f);
            //String se = "";


            //if (s.Length < 3)
            //{
            //    for (int i = 0; i < 3; i++)
            //    {
            //        se += s;

            //    }
            //    Console.WriteLine(se);
            //}
            //else
            //{


            //        se += s[0];
            //        se += s[1];
            //        se += s[2];
            //    String f = se;



            //    se += s;
            //    se += f;
            //    Console.WriteLine(se);
            //}

            //char l = s[s.Length - 1];
            //s = l + s + l;

            //Console.Write(s);

            //int n = int.Parse(Console.ReadLine());
            //if (n % 3 == 0 || n % 7 == 0)
            //{
            //    Console.WriteLine("true");
            //}
            //else
            //    Console.WriteLine("false");

            /*
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            if (Math.Min(n1, n2) < 0 && Math.Max(n1, n2) > 100)
            {
                Console.WriteLine("true");

            }
            else
                Console.WriteLine("false");

            */


            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine($"{num1} and {num2} are equal");
            }
            else
            {
                Console.WriteLine($"{num1} and {num2} are not equal");
            }

            //Q2.1



        }
    }
}
