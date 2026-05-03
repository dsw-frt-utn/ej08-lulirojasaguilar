namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio 1

            Console.WriteLine("PROBLEMA 1\n");

            ProductHelper helper = new ProductHelper();

            string etiqueta = helper.ObtenerEtiquetaProducto( 1001,"Mouse Gamer", 15000);

            Console.WriteLine(etiqueta);

            // Ejercicio 2

            Console.WriteLine("\nPROBLEMA 2\n");

            Problema2 venta = new Problema2();

            string resultadoVenta = venta.CrearResumenVenta(2001, "Auriculares",3, 5000 );

            Console.WriteLine(resultadoVenta);

            // Ejercicio 3

            Console.WriteLine("\nPROBLEMA 3\n");

            Product producto = new Product();

            producto.SetDescription("Mouse Gamer");

            Problema3 problema = new Problema3();

            string resultadoProblema3 = problema.CompararCopias(10, producto);

            Console.WriteLine(resultadoProblema3);

            //Ejercicio 4

            Console.WriteLine("\nPROBLEMA 4\n");

            Problema4 problema4 = new Problema4();

            double promedio = problema4.CalcularPromedio(8, null, 10);

            Console.WriteLine(promedio);

            //Ejercicio 5

            Console.WriteLine("\nPROBLEMA 5\n");

            Problema5 problema5 = new Problema5();

            // Venta min

            Console.WriteLine("Venta minorista\n");

            RetailSale retail = new RetailSale();

            retail.Amount = 10000;

            decimal totalRetail = problema5.ObtenerImporteFinal(retail);

            Console.WriteLine(totalRetail);

            // Venta may

            Console.WriteLine("\nVenta mayorista\n");

            WholesaleSale wholesale = new WholesaleSale();

            wholesale.Amount = 10000;

            decimal totalWholesale = problema5.ObtenerImporteFinal(wholesale);

            Console.WriteLine(totalWholesale);

            //Ejercicio 6

            Console.WriteLine("\nPROBLEMA 6\n");

            Problema6 problema6 = new Problema6();

            string resultado = problema6.NormalizarCodigoProducto(" ab 123 x ");

            Console.WriteLine(resultado);

        }
    }
}
