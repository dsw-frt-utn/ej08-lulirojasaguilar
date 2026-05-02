using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal partial class ProductHelper
    {
        public string FormatearMoneda(decimal price)
        {
            return $"{price:C2}";
        }
    }
}
