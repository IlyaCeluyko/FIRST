using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Создать массив строк разной длины. На основе LINQ подсчитать количество строк которые начинаются с А.
/// </summary>

namespace first
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = new string[] { "qwe", "q", "qw", "assss", "accc", "qas" };
            var result = arr.Select(s => s[0] == 'a');
            int countA = 0;
            foreach (var item in result)
            {
                if (item)
                {
                    countA++;
                }
            }

            Console.WriteLine(countA);

            
        }
    }
}
