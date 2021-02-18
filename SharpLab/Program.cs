using System;
using System.Collections.Generic;
using System.IO;

namespace SharpLab
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ArrayHandler handler = new ArrayHandler("");
                if (handler.Digits != null)
                {
                    List<int> list = new List<int>(handler.SimpleToList());
                    Console.WriteLine("Список простых чисел:");
                    foreach (int i in list)
                        Console.WriteLine(i);
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("\nЗавершение работы.\nНажмите любую клавишу");
                Console.ReadKey();
            } 
        }
    }
}
