using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumNumber
{
     public class FindMaximum
    {
         public int FindMaxIntNumber(int firstnum, int secondnum, int thirdnum)
         {
             if (firstnum.CompareTo(secondnum) > 0 && firstnum.CompareTo(secondnum) > 0)
                 return firstnum;
             if (secondnum.CompareTo(firstnum) > 0 && secondnum.CompareTo(thirdnum) > 0)
                 return secondnum;
             else
                 return thirdnum;

         }
         public float FindMaxFloatNumber(float firstnum, float secondnum, float thirdnum)
         {
             if (firstnum.CompareTo(secondnum) > 0 && firstnum.CompareTo(secondnum) > 0)
                 return firstnum;
             if (secondnum.CompareTo(firstnum) > 0 && secondnum.CompareTo(thirdnum) > 0)
                 return secondnum;
             else
                 return thirdnum;

         }
    }
}
