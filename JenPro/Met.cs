using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JenPro
{
    public class Met
    {       
        public Met()
        {

        }
        public static int square(int n)
        {
            return n * n;
        }

        public static Boolean IsNan(int m)
        {
            if (double.IsNaN(m))
                return true;
            else
                return false;
        }
    }
}
