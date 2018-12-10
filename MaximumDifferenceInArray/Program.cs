using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumDifferenceInArray
{
    class Program
    {
        /* This program will find the maximum difference of integer elements in an integer array */
        static void Main(string[] args)
        {
            List<int> list1 = new List<int>() { 1, 2, 4, 6 };
            Console.WriteLine(" Maximum Difference is : {0}", MaxDiffCalculation.Finder(list1));
            Console.ReadKey();
        }
    }

    static class MaxDiffCalculation
    {
        /* This class contains the method to find maximum difference of array elements
         */
        public static int Finder(List<int> intList)
        {
            List<int> maxDiffernce = new List<int>();
            /* This loop will make sure every int value is checked */
            for(int ch=0; ch<=intList.Count-1;ch++)
            {
                /* this variable will store right value 
                 which will be subtracted by all values in left*/
                int firstNumberfromRight = intList[ch];

                /* this loop will run from RIGHT value to all left and will subtract each items on LEFT with the right value 
                 * so For example this array {1,2,4,6} 
                 * first 1 will be right value, and will subtract with nothing
                 * 2nd 2 will be right value and will be subtracted with 1 only
                 * 3rd 4 will be right value and will be subtracted with 2 and 1
                 * 4th 6 will be right value and will be subtacted with 4,2,1
                 * maximum difference will be when 6 will subtract 1. Result will be 5
                 */
                for (int th=ch-1;th>=0;th--)
                {
                    // maxDifference is the LIST which will store all the differences 
                    maxDiffernce.Add(firstNumberfromRight - intList[th]);
                }
            }
            /* checking if the result is negative or zero */
            if (maxDiffernce.Max() > 0)
            {
                return maxDiffernce.Max();
            }
            else
            {
                return -1;
            }
        }
    }
}
