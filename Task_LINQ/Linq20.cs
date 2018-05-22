using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_LINQ
{
    public class Linq20
    {
        public static List<int> MainTask(List<int> _list)
        {
            List<int> list = _list;
            int number = list[0];
            list.RemoveAt(0);
            var result = list.SkipWhile(x => x <= number).Where(x => x % 2 != 0 && x > 0).Reverse();
            return result.ToList();
        }
    }
}
