using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Problema4
    {
        public double CalcularPromedio(int? nota1, int? nota2, int? nota3)
        {
            int suma = 0;
            int cantidad = 0;

            // Nota 1
            if (nota1 != null && nota1 >= 0 && nota1 <= 10)
            {
                suma += nota1.Value;
                cantidad++;
            }

            // Nota 2
            if (nota2 != null && nota2 >= 0 && nota2 <= 10)
            {
                suma += nota2.Value;
                cantidad++;
            }

            // Nota 3
            if (nota3 != null && nota3 >= 0 && nota3 <= 10)
            {
                suma += nota3.Value;
                cantidad++;
            }

            // Si no hay notas válidas
            if (cantidad == 0)
            {
                return 0;
            }

            return (double)suma / cantidad;
        }

    }
}
