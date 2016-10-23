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
            Console.WriteLine(Increase(5));
            Console.WriteLine(IncreaseOrDecrease(2, 10));
            Console.WriteLine(IncreaseOrDecrease(10, 3));
            Console.WriteLine(PowerOfTwo(12));
            Console.WriteLine(AmountInFigures(1111111));
            Console.WriteLine(PermutationOfDigits(495039));
            Console.WriteLine(CheckEase(269,5));

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
            
                if (n< 10)
                {
                    return sum=+n;
                }
            sum=+AmountInFigures(n / 10) + n % 10;
                return sum;
            }

        //6-задача Цифры числа справа на лево
        public static string PermutationOfDigits(int n)
        {
            if(n<10)
            {
                return n+" ";
            }
            return n % 10 +" "+ PermutationOfDigits(n / 10);
        }

        //7-задача
        //вроде работает -Определение простого числа
        public static string CheckEase(int n, int k)
        {
            if (n % 2 != 0)
            {
               
                if (n == 1)
                {
                    return "Yes";
                }
                if (n >= k && n % k == 0)
                {
                    if(n==k)
                    {
                        return "Yes";
                    }
                    return "No";
                }
                else if (n >= k && n % k != 0)
                {
                    return CheckEase(n, k + 1);
                }
            }
            else
            {
                if (n == 2)
                {
                    return "Yes";
                }
                return "No";
            }
           return " ";//не знаю что вернуть в этом случае функции
    

            }


        //8-я задача Разложение на множители

        public static string Factorization(int n, int k)
        {
            if (n % 2 != 0)
            {
                if (n == 1)
                {
                    return n+"";
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
                    return Factorization(n,k+1);
                }
            }
            else
            {
                if (n == 1)
                {
                    return n+"";
                }
                if (n % 2 != 0)
                {
                    return n + "";
                }
                return Factorization(n / 2, k);
            }
            return " ";//не знаю что вернуть в этом случае функции
        }

        }
        }


        
    


