//https://leetcode.com/problems/search-in-rotated-sorted-array/
//Accepted
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_in_Rotated_Sorted_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 0, 1, 2, 3, 4, 5, 6, 7 };
            Program p = new Program();

            p.Search(array, 1);
        }

        public int Search(int[] nums, int target)
        {
            // just use LINQ
            // should remember how to find the index of a element in an array.

            int[] _array = new int[0];
            
            _array = nums.Select((ele, idx) => new { idx, ele })
                .Where(x => x.ele == target)
                .Select(x => x.idx)
                .ToArray();

            if (_array.Length < 1)
            {
                return -1;
            }
            else
            {
                return _array[0];
            }
        }
    }
}
