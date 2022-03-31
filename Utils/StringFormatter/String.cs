using System;
using System.Collections.Generic;
using System.Text;

namespace DocspiderWebAutomation.Utils.StringFormatter
{
    public static class String
    {
        public static string ListToString(List<string> list)
        {
            string paragrafos = string.Empty;

            foreach (var item in list)
            {
                paragrafos += $"{item}\n";
            }
            return paragrafos;
        }
    }
}
