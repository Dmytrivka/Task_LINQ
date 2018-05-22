using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_LINQ
{
    public class Linq44
    {
        public static List<int> MainTask(string[] _array)
        {
            string[] array = _array;
            int numberA = 0, numberB = 0;
            if (!Int32.TryParse(array[0], out numberA) || !Int32.TryParse(array[1], out numberB))
            {
                Console.WriteLine("Error");
            }
            else
            {
                int value = 0;
                var list1 = array[2].Split(' ').Where(x => Int32.TryParse(x, out value)).Select(x => value).ToList();
                var list2 = array[3].Split(' ').Where(x => Int32.TryParse(x, out value)).Select(x => value).ToList();
                var list3 = (list1.Where(x => x > numberA).Concat(list2.Where(x => x < numberB)).OrderBy(x => x)).ToList();
                return list3.ToList();
            }
            return null;
        }
    }
}
