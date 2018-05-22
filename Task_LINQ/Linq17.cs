using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_LINQ
{
    public class Linq17
    {
        public static List<int> MainTask(List<int> _list)
        {
            List<int> list = _list;
            var result = (from it in list where it % 2 != 0 select it).Distinct();
            return result.ToList();
        }
    }
}
