using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1_Solution
{
    public class SortingSubsets
    {
        public int GetMinimalSize(int[] a)
        {
            List<int> arr = (from num in a
                            orderby num
                            select num).ToList();
            
            return (from nums in a.Zip(arr)
                    where nums.First != nums.Second
                    select nums).Count(); ;
        }
    }
}
