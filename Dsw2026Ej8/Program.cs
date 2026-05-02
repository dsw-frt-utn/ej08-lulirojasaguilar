namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio 1

            ProductHelper helper = new ProductHelper();

            string etiqueta = helper.ObtenerEtiquetaProducto( 1001,"Mouse Gamer", 15000);

            Console.WriteLine(etiqueta);

           // Ejercicio 2

            Problema2 venta = new Problema2();

            string resultadoVenta = venta.CrearResumenVenta(2001, "Auriculares",3, 5000 );

            Console.WriteLine(resultadoVenta);

            // Ejercicio 3

            Product producto = new Product();

            producto.SetDescription("Mouse Gamer");

            Problema3 problema = new Problema3();

            string resultadoProblema3 = problema.CompararCopias(10, producto);

            Console.WriteLine(resultadoProblema3);



        }
    }
}
