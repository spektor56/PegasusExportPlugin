using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PegasusExportPlugin.Extensions
{
    public static class String
    {
        public static bool EndsWith(this string stringValue, char value)
        {
            int length = stringValue.Length;
            return length != 0 && (int)stringValue[length - 1] == (int)value;
        }
    }
}
