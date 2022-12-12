using System;

namespace _12122022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task1-21-e bolunenlerin ededi ortasi
            //Console.WriteLine("n ededi daxil edin:");
            //string nStr = Console.ReadLine();
            //int n = Convert.ToInt32(nStr);

            //Console.WriteLine("m ededini daxil edin:");
            //string mStr = Console.ReadLine();
            //int m = Convert.ToInt32(mStr);

            //int sum = 0;
            //int count = 0;

            //for (int i = m; i < n; i++)
            //{
            //    if (i % 21 == 0)
            //    {
            //        count++;
            //        sum += i;
            //    }
            //}

            //if (count > 0)
            //{
            //    var result = sum / count;
            //    Console.WriteLine(result);
            //}
            //else
            //{
            //    Console.WriteLine("21-e bolunen eded yoxdur!");
            //}
            #endregion

            #region task2-Verilmiş ədədin rəqəmləri cəmini tapan proqram

            //Console.WriteLine("N ededini daxil edin:");
            //string nStr = Console.ReadLine();   

            //int n = Convert.ToInt32(nStr);
            //int sum = 0;

            //while (n > 0)
            //{
            //    sum += n % 10;
            //    n = (n - n % 10) / 10;
            //}

            //Console.WriteLine("reqemleri cemi: "+sum);
            //Console.WriteLine("reqemleri cemi: {0}",sum);
            //Console.WriteLine($"reqemleri cemi: {sum}");


            #endregion


            #region task3-Verilmiş ayın ədədinə görə hansı fəsil olduğunu tapan proqram

            //Console.WriteLine("Ayi daxil et:");
            //string monthStr = Console.ReadLine();
            //int month = Convert.ToInt32(monthStr);

            //if(month>=1 && month <= 12)
            //{
            //    if (month >= 3 && month <= 5)
            //        Console.WriteLine("Yazdir");
            //    else if (month >= 6 && month <= 8)
            //        Console.WriteLine("Yaydir");
            //    else if(month>=9 && month <= 11)
            //        Console.WriteLine("Payizdir");
            //    else
            //        Console.WriteLine("Qisdir");
            //}
            //else
            //    Console.WriteLine("Ay yanlisdir!");


            #endregion

            //Verilmiş yazıda rəqəm olmamasını yoxlayan proqram, əgər rəqəm varsa yenidən
            //yazının daxil edilməsini istəməlidir ta ki rəqəmsiz daxil edilənədək
            #region Task-4

            //bool hasDigit;
            //char[] digits = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            //do
            //{
            //    Console.WriteLine("Yazini daxil et:");
            //    string text = Console.ReadLine();

            //    hasDigit = false;
            //    //yoxla

            //    for (int i = 0; i < text.Length; i++)
            //    {
            //        //if(text[i]=='0' || text[i]=='1' || text[i]=='2' || text[i]=='3' || text[i] == '4' || text[i] == '5' || text[i] == '6' || text[i] == '7' || text[i]=='8' || text[i] == '9')
            //        //{
            //        //    hasDigit = true;
            //        //    break;
            //        //}

            //        //for (int j = 0; j < digits.Length; j++)
            //        //{
            //        //    if (digits[j] == text[i])
            //        //    {
            //        //        hasDigit = true;
            //        //        break;
            //        //    }
            //        //}

            //        //if (hasDigit==true)
            //        //{
            //        //    break;
            //        //}

            //        //if(text[i]>='0' && text[i] <= '9')
            //        //{

            //        //}
            //    }


            //} while (hasDigit==true);


            #endregion


            #region Task-Calculator
            Console.WriteLine("eded 1:");
            string num1Str = Console.ReadLine();
            int num1 = Convert.ToInt32(num1Str);

            Console.WriteLine("eded 2:");
            string num2Str = Console.ReadLine();
            int num2 = Convert.ToInt32(num2Str);

            Console.WriteLine("operator :");
            string opt = Console.ReadLine();
            int result;

            //if (opt == "+")
            //{
            //    result = num1 + num2;
            //    Console.WriteLine(result);
            //}
            //else if(opt == "-")
            //{
            //    result = num1 - num2;
            //    Console.WriteLine(result);
            //}
            //else if (opt == "*")
            //{
            //    result = num1 * num2;
            //    Console.WriteLine(result);
            //}
            //else if (opt == "/")
            //{
            //    if (num2 == 0)
            //    {
            //        Console.WriteLine("0-a bolme yoxdur!");
            //    }
            //    else
            //    {
            //        result = num1 / num2;
            //        Console.WriteLine(result);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Oprator yanlisdir!");
            //}


            switch (opt)
            {
                case "+":
                    result = num1 + num2;
                    Console.WriteLine(result);
                    break;
                case "-":
                    result = num1 - num2;
                    Console.WriteLine(result);
                    break;
                case "*":
                    result = num1 * num2;
                    Console.WriteLine(result);
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        Console.WriteLine("0-a bolme yoxdur");
                    }
                    else
                    {
                        result = num1 / num2;
                        Console.WriteLine(result);
                    }
                    break;
                default:
                    Console.WriteLine("Operator yanlisdir");
                    break;
            }


            #endregion

        }
    }
}
