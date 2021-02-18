using System;
using System.Collections.Generic;
using System.IO;

namespace SharpLab
{
        class ArrayHandler
    {
        private int[] digits;
        public int[] Digits { get => digits; set => digits = value; }
        public ArrayHandler()
        {
        }
        public ArrayHandler(String path)
        {
            Extract(path);
        }
        public void Extract(String path)
        {
                if (path.Length != 0)                  
                {
                    string[] arr = File.ReadAllLines(path);
                    Digits = new int[arr.Length];
                    for (int i = 0; i < arr.Length; i++)
                    {
                        try
                        {
                            Digits[i] = Int32.Parse(arr[i]);
                        }
                        catch { }
                    }
                }
                else
            {
                Console.WriteLine("Ошибка: неверно указан путь");
            }

            
        }
        public List<int> SimpleToList()
        {
            bool simple;
            int modnum;
            List<int> list = new List<int>();
            foreach (int num in Digits)
            {
                simple = true;
                modnum = Math.Abs(num);
                if (modnum > 1)
                {
                    for (var i = 2u; i < modnum; i++)
                    {
                        if (modnum % i == 0)
                        {
                            simple = false;
                            break;
                        }
                    }
                }
                else
                {
                    simple = false;
                }
                if (simple) list.Add(num);

            }
            Console.WriteLine("Алгоритм завершён. Количество простых чисел в массиве: {0}\nДля продолжения нажмите любую клавишу", list.Count);
            Console.ReadKey();
            return list;
        }
    }
}