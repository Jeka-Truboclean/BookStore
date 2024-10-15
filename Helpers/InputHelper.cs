using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Helpers
{
    internal class InputHelper
    {
        public static int GetInt(string value)
        {
            int result = 0;
            Console.Write("{0} {1}: ", _submessage, value);
            while (!int.TryParse(Console.ReadLine(), out result))
            {
                Console.Write("{0} {1}: ", submessage, value);
            }
            return result;
        }
    }
}
