using System;
using System.Collections.Generic;
using System.IO;
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

        public static string UniqueFileName(this string fullFileName)
        {
            var newFileName = fullFileName;

            var fileName = Path.GetFileNameWithoutExtension(fullFileName);
            var directory = Path.GetDirectoryName(fullFileName);
            var fileExtension = Path.GetExtension(fullFileName);

            int i = 0;

            while (File.Exists(newFileName))
            {
                newFileName = Path.Combine(directory ?? "", fileName + " (" + (++i) + ")" + fileExtension);
            }
            return newFileName;
        }
    }
}
