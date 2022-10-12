using ExeptionDll;
using System;
using System.Collections.Generic;

namespace TryCatchPractise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region try
            //Console.WriteLine("Reqem daxil edin");

            //string num=Console.ReadLine(); //"lorem"
            //bool loop = true;
            //while (loop)
            //{
            //    try
            //    {
            //        int result = int.Parse(num);
            //        Console.BackgroundColor = ConsoleColor.Magenta;
            //        Console.WriteLine("=====================");
            //        Console.WriteLine(result);
            //        loop = false;
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //        Console.WriteLine("Duzgun eded daxil et");
            //        num = Console.ReadLine();
            //    }
            //    finally
            //    {
            //        Console.WriteLine("finally ishledi");
            //    }
            //}

            //Action<int,string> lorem = (n,m) => Console.WriteLine(n);
            //Predicate<string> lorem1 = n => n.Length>5;
            //Func<int, string, int, int> lorem3 = (n, m, k) =>
            //{
            //    Console.WriteLine();
            //    return 0;
            //};
            #endregion

            #region s
            //try
            //{
            //    int num = int.Parse(Console.ReadLine());
            //    int num1 = int.Parse(Console.ReadLine());

            //    int result = num / num1;
            //    Console.WriteLine(result);
            //}

            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch (Exception ex)
            //{
            //    //Console.WriteLine(ex.Message);
            //}
            //int[] numbers = { 1, 2, 3 };
            //List<int> numbers = new List<int>();
            //numbers.Add(1);
            //numbers.Add(2);
            //numbers.Add(3);
            //try
            //{
            //    int? result = numbers.Find(k => k == 66);
            //    if (result==0)
            //    {
            //        throw new NotFoundExeption($"4 tapilmadi");
            //    }


            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    throw;
            //}
            #endregion
            Console.WriteLine("Sozu daxil edin.");
            string word= Console.ReadLine();
            char charr = Convert.ToChar(word.Substring(0,1));
            try
            {
                if (charr > 'A' && charr < 'Z')
                {
                    Console.WriteLine("Herf Boyukdur.");
                }
                else
                {
                    throw new UpperException("Herf kicikdir");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }

        }
    }
}
