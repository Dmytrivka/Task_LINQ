using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_LINQ
{
    class Program
    {
        private static List<int> IntParse(string path_file)
        {
            string[] array = File.ReadAllText(path_file).ToString().Split(' ');
            int number;
            List<int> list = new List<int>();
            foreach (var it in array)
            {
                if (Int32.TryParse(it, out number))
                {
                    list.Add(number);
                }
            }
            return list;
        }

        static void Main(string[] args)
        {
            var listLinq16 = IntParse("Linq16.txt");

            var listLinq17 = IntParse("Linq17.txt");

            var listLinq18 = IntParse("Linq18.txt");

            var result1 = Linq16.MainTask(listLinq16);
            var result2 = Linq17.MainTask(listLinq17);
            var result3 = Linq18.MainTask(listLinq18);

            string[] array = File.ReadAllText("Linq19.txt").ToString().Split(' ');

            var result4 = Linq19.MainTask(array);

            var listLinq20 = IntParse("Linq20.txt");

            var result5 = Linq20.MainTask(listLinq20);

            string[] array2 = File.ReadAllText("Linq44.txt").ToString().Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            var result6 = Linq44.MainTask(array2);

            string[] array3 = File.ReadAllText("Linq45.txt").ToString().Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            var result7 = Linq45.MainTask(array3);

            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter("AnsLinq16.txt"))
            {
                file.WriteLine(result1.ToString());
            }

            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter("AnsLinq17.txt"))
            {
                file.WriteLine(result2.ToString());
            }

            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter("AnsLinq18.txt"))
            {
                file.WriteLine(result3.ToString());
            }

            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter("AnsLinq19.txt"))
            {
                file.WriteLine(result4.ToString());
            }

            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter("AnsLinq20.txt"))
            {
                file.WriteLine(result5.ToString());
            }

            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter("AnsLinq44.txt"))
            {
                file.WriteLine(result6.ToString());
            }

            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter("AnsLinq45.txt"))
            {
                file.WriteLine(result6.ToString());
            }
        }
    }
}
