using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Isograms
{
    internal class Program
    {
     // An isogram is a word that has no repeating letters, consecutive or non-consecutive.
     // Implement a function that determines whether a string that contains only letters is an isogram. Assume the empty string is an isogram. Ignore letter case.

     // Изограмма — это слово, в котором нет повторяющихся букв, последовательных или непоследовательных.
     // Реализуйте функцию, определяющую, является ли строка, содержащая только буквы, изограммой. Предположим, что пустая строка является изограммой.
     // Игнорировать регистр букв.
     
        static void Main(string[] args)
        {
            List<int> ages = new List<int> { 21, 46, 46, 55, 17, 21, 55, 55 };

            IEnumerable<int> distinctAges = ages.Distinct();

            Console.WriteLine("Distinct ages:");

            foreach (int age in distinctAges)
            {
                Console.WriteLine(age);
            }

            IsIsogram("aaaaaa");
            Console.WriteLine(IsIsogram("aaaaa"));
            Console.ReadLine();
        }

        public static bool IsIsogram(string str)
        {
            return str.ToLower().Distinct().Count() == str.Length;
        }
    }
}