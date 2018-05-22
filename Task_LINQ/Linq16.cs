using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_LINQ
{
    public class Linq16
    {
        public static List<int> MainTask(List<int> _list)
        {
            List<int> list = _list;
            var result = from it in list where it > 0 select it;
            return result.ToList();
        }
    }
}
