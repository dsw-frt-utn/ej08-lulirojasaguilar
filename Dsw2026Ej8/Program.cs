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

        }
    }
}
