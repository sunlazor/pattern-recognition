using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Genetic
{
    class Utils
    {
        public static byte StayInByte(int num)
        {
            if (num < byte.MinValue)
                return byte.MinValue;
            else if (num > byte.MaxValue)
                return byte.MaxValue;
            else
                return Convert.ToByte(num);
        }
    }
}
