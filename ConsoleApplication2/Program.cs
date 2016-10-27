using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
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
                Console.WriteLine("From a to b : " + IncreaseOrDecrease(2, 10));
                Console.WriteLine("From b to a : " + IncreaseOrDecrease(10, 3));
                Console.WriteLine("Power 2 number 12: " + PowerOfTwo(12));
                Console.WriteLine("Amount in figures -1111111: " + AmountInFigures(1111111));
                Console.WriteLine("Digit numbers from left to right - 4 9 5 0 3 9 :" + PermutationOfDigits(495039));
                Console.WriteLine("Verification of the simplicity- 18, 5 : " + (CheckEase(18, 5)));
                Console.WriteLine("Verification of the simplicity- 29, 5 : " + (CheckEase(29, 5)));
                Console.WriteLine("Factorization: " + Factorization(45, 5));
                Console.WriteLine("Palindrome: " + Palindrome("2FUgrgUF2"));
                Console.WriteLine("Enter a sequence of numbers for odd parity:");
                IdentificationOddNumbers();
                Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Enter a sequence of numbers to identify the max value:");
                Console.WriteLine(Max());
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


            //4-задача Степень двойки
            public static string PowerOfTwo(int n)
            {
                if (n == 1)
                {
                    return "Yes";
                }
                if (n % 2 == 0)
                {

                    return PowerOfTwo(n / 2);
                }
                else
                {
                    return "No";

                }
            }

            //5-задача Сумма цифр числа
            public static int AmountInFigures(int n)
            {
                int sum;

                if (n < 10)
                {
                    return sum = n;
                }
                sum = AmountInFigures(n / 10) + n % 10;
                return sum;
            }

            //6-задача Цифры числа справа налево
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

            public static string CheckEase(int n, int k)
            {
                if (n % 2 != 0)
                {
                    if (n % k == 0)
                    {
                        return "No";
                    }

                    else if (k < n / 2)
                    {
                        return CheckEase(n, k + 1);
                    }
                    else
                    {
                        return "Yes";
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


            }

            //8-я задача Разложение на множители
            public static string Factorization(int n, int k)
            {

                if (n > 2)
                {
                    if (k > n / 2)
                    {
                        return n.ToString();
                    }


                    if (n % k == 0)
                    {
                        return Factorization(n / k, k) + " " + k;
                    }
                    else
                    {
                        return Factorization(n, k + 1);
                    }

                }
                else
                {
                    return n.ToString();
                }
            }

            //Полиндром
            public static string Palindrome(string a)
            {
                if (a.Length == 1 || a.Length == 0)
                {
                    return "Yes";
                }


                if (a[0] == a[a.Length - 1])
                {

                    return Palindrome(a.Substring(1, a.Length - 2));

                }
                else
                {
                    return "No";
                }
            }


            //вывести все нечетные числа
            public static void IdentificationOddNumbers()
            {
                int number = (int)Char.GetNumericValue(Convert.ToChar(Console.Read()));

                if (number <= 0)
                {
                    return;
                }

                if (number % 2 != 0)
                {
                    Console.Write(number + " ");
                }

                IdentificationOddNumbers();
            }

            //вывести мах число последовательности
            public static int Max()
            {
                int number = (int)Char.GetNumericValue(Convert.ToChar(Console.Read()));

                if (number <= 0)
                {
                    return 0;
                }
                return Math.Max(number, Max());

            }

        }
    }
}
