using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sumnumbers
{
    public class Sum
    {
       
        public int SumMethod(List <int> numbers)
        {
            if (numbers != null)
            {
                return numbers.Sum();
            }
            else
            {
                return 5;
            }
        }

    }
}
