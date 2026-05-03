using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal static class Extension
    {
        public static string ToProductCode(this string code)
        {
            if (code == null)
            {
                return "SIN-CODIGO";
            }

            code = code.Trim();

            code = code.ToUpper();

            code = code.Replace(" ", "-");

            return code;
        }
    }
}
