using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_LINQ
{
    public class Linq19
    {
        public static List<string> MainTask(string[] _array)
        {
            string[] array = _array;
            var result = array.OrderByDescending(x => x.Length).Reverse();
            return result.ToList();
        }
    }
}
