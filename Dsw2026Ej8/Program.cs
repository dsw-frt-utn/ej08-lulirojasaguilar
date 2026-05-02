namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio 1

            ProductHelper helper = new ProductHelper();

            string etiqueta = helper.ObtenerEtiquetaProducto(
                1001,
                "Mouse Gamer",
                15000
            );

            Console.WriteLine(etiqueta);

           // Ejercicio 2

            Problema2 venta = new Problema2();

            string resultadoVenta = venta.CrearResumenVenta(
                2001,
                "Auriculares",
                3,
                5000
            );

            Console.WriteLine(resultadoVenta);

        }
    }
}
