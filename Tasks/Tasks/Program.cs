using System;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task1
            //Console.WriteLine("eded1:");
            //string num1Str = Console.ReadLine();

            //Console.WriteLine("eded2:");
            //string num2Str = Console.ReadLine();

            //int num1 = Convert.ToInt32(num1Str);
            //int num2 = Convert.ToInt32(num2Str);

            //var sumResult = Sum(num1, num2);
            //Console.WriteLine(sumResult);
            #endregion


            #region task2

            var check = IsEven(100);
            #endregion


        }

        //Verilmis iki ededi toplayiq neticesini qaytran metod

        static int Sum(int x,int y)
        {
            return x + y;
        }

        //Verilmis deyerin cut olub olmadigini tapan metod
        static bool IsEven(int num)
        {
            return num % 2 == 0;
        }



            
    }
}
