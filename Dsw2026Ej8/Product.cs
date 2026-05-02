using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Product
    {
        private string description;

        public string GetDescription()
        {
            return description;
        }

        public void SetDescription(string nuevaDescripcion)
        {
            description = nuevaDescripcion;
        }

        public void CambiarDescripcion(string nuevaDescripcion)
        {
            description = nuevaDescripcion;
        }
    }
}
