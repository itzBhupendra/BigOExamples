using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmsLibrary
{
    public class FindDuplicate
    {
        public int? findInteger(List<int> listOfInteger)
        {
            HashSet<int> hashOfInteger = new HashSet<int>();

            foreach (var item in listOfInteger)
            {
                if (hashOfInteger.Contains(item))
                    return item;
                hashOfInteger.Add(item);

            }
            return null;
        }
    }
}
