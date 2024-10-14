using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas.Actividad
{
    public class ArraySinRepetidos
    {
        public static void sinRepetidos()
        {
            List<int> list1 = new List<int> { 1, 2, 3, 4, 5};
            List<int> list2 = new List<int> { 4, 5, 6, 7, 8};
            List<int> list3 = new List<int> { 7, 8, 9, 10, 11};
            List<int> list4 = new List<int> { 10, 11, 12, 13, 14};

            HashSet<int> set = new HashSet<int>();
            set.UnionWith(list1);
            set.UnionWith(list2);
            set.UnionWith(list3);
            set.UnionWith(list4);

            foreach (int i in set)
            {
                Console.WriteLine(i);
            }
        }
    }
}
