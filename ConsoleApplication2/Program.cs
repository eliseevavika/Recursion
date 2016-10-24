using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("From 1 to n: " + Increase(5));
            Console.WriteLine("From a to b : "+ IncreaseOrDecrease(2, 10));
            Console.WriteLine("From b to a : "+ IncreaseOrDecrease(10, 3));
            Console.WriteLine("Power 2 number 12: " +PowerOfTwo(12));
            Console.WriteLine("Amount in figures -1111111: "+AmountInFigures(1111111));
            Console.WriteLine("Digit numbers from left to right - 4 9 5 0 3 9 :"+PermutationOfDigits(495039));
            Console.WriteLine("Verification of the simplicity- 18, 5 : " + (CheckEase(18, 5)));
            Console.WriteLine("Verification of the simplicity- 29, 5 : " + (CheckEase(29, 5)));
            

            Console.ReadLine();
        }

     
        //1-задача От 1 до n
        public static string Increase(int n)
        {

            if (n == 1)
            {
                return "1";
            }

            return Increase(n - 1) + ' ' + n;
        }
        //2-задача От а до в
        public static string IncreaseOrDecrease(int a, int b)
        {
            if (a < b)
            {

                if (a == b)
                {
                    return b + "";
                }
                return a + " " + IncreaseOrDecrease(a + 1, b);
            }
            else
            {

                if (a == b)
                {
                    return b + "";
                }
                return a + " " + IncreaseOrDecrease(a - 1, b);
            }
        }

        //3-задача
        /*  public static string Akkerman(int m, int n)
          {
              if(m==0)
              {
                  if()

              }

              if(m>0 && n==0)
              {

              }
              if(m>0 && n>0)
              {

              }         
          }
          */
        //4-задача Степень двойки
        public static string PowerOfTwo(int n)
        {
            if (n % 2 == 0)
            {
                if (n == 1)
                {
                    return "Yes";
                }
                PowerOfTwo(n / 2);
                return "Yes"; // как здесь сдалать так, чтобы сначала полностью рекурсия прошла, и только потом сказал,что Yes
            }


            else
            {
                if (n == 1)
                {
                    return "Yes";
                }
                return "No";

            }
        }

        //5-задача Сумма цифр числа
        public static int AmountInFigures(int n)
        {
            int sum;

            if (n < 10)
            {
                return sum = +n;
            }
            sum = +AmountInFigures(n / 10) + n % 10;
            return sum;
        }

        //6-задача Цифры числа справа на лево
        public static string PermutationOfDigits(int n)
        {
            if (n < 10)
            {
                return n + " ";
            }
            return n % 10 + " " + PermutationOfDigits(n / 10);
        }

        //7-задач
        //Определение простого числа

        public static bool CheckEase(int n, int k)
        {
            if (n % 2 != 0)
            {
                if (n % k == 0)
                {
                    return false;
                }

                else if (k < n / 2)
                {
                    return CheckEase(n, k + 1);
                }
                else
                {
                    return true;
                }
            }

            else
            {
                if (n == 2)
                {
                    return true;
                }
                return false;
            }
         

        }


        
            public static bool Recursion(int n, int i)
            {
                if (n < 2)
                {
                    return false;
                } // Базовый случай 
                else if (n == 2)
                {
                    return true;
                } // Базовый случай 
                else if (n % i == 0)
                {
                    return false;
                } // Шаг рекурсии / рекурсивное условие
                else if (i < n / 2)
                {
                    return Recursion(n, i + 1);
                }
                else
                {
                    return true;
                }

            }

            //8-я задача Разложение на множители - НЕ работает

            public static string Factorization(int n, int k)
            {
                if (n % 2 != 0)
                {
                    if (n == 1)
                    {
                        return n + "";
                    }
                    if (n >= k && n % k == 0)
                    {
                        if (n == k)
                        {
                            return "Yes";
                        }
                        return "No";
                    }
                    else if (n >= k && n % k != 0)
                    {
                        return Factorization(n, k + 1);
                    }
                }
                else
                {
                    if (n == 1)
                    {
                        return n + "";
                    }
                    if (n % 2 != 0)
                    {
                        return n + "";
                    }
                    return Factorization(n / 2, k);
                }
                return " ";//не знаю что вернуть в этом случае функции
            }

            public static string Palindrome(string a)
            {
                if (a.Length == 1)
                {
                    return "Yes";
                }
                if (a.Length % 2 == 0)
                {
                    return Palindrome(a.Length / 2 + "");


                }
                else
                {
                    return "No";
                }
                if (a.Length / 2 == 2)

                    return "";
            }

        }
    }







