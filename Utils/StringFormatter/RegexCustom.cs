using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace DocspiderWebAutomation.Utils.StringFormatter
{
    public static class RegexCustom
    {
        public static string NormalizeStringToSave(string text)
        {
            return text.Replace("á", "a").Replace("ã", "a").Replace("ó", "o").Replace("ç", "c");
        }
    }
}
