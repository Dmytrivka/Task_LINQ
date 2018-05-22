using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_LINQ
{
    public class Linq45
    {
        public static List<string> MainTask(string[] _array)
        {
            string[] array = _array;
            int numberA = 0, numberB = 0;
            if (!Int32.TryParse(array[0], out numberA) || !Int32.TryParse(array[1], out numberB))
            {
                Console.WriteLine("Error");
            }
            else
            {
                var list1 = array[2].Split(' ');
                var list2 = array[3].Split(' ');
                var list3 = list1.Where(x => x.Length == numberA).Concat(list2.Where(x => x.Length == numberB)).OrderBy(x => x).Reverse();
                return list3.ToList();
            }
            return null;
        }
    }
}
