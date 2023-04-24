internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<int, string> ClientesRegistrados = new Dictionary<int, string>();
    }
    static int Menu(Dictionary<int, string> ClientesRegistrados)
    {
        int opcion = 0;
        do
        {
            Console.WriteLine("1. Nueva inscripción");
            Console.WriteLine("2. Obtener Estadísticas del Evento");
            Console.WriteLine("3. Buscar cliente");
            Console.WriteLine("4. Cambiar entrada de un Cliente");
            Console.WriteLine("5. Salir");
            opcion = IngresarEntero("Ingrese una de las opciones.");
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Opción 1 - Día 1 , valor a abonar $15000");
                    Console.WriteLine("Opción 2 - Día 2, valor a abonar $30000");
                    Console.WriteLine("Opción 3 - Día 3, valor a abonar $10000");
                    Console.WriteLine("Opción 4 - Full Pass, valor a abonar $40000");
                    NuevaInscripcion(ClientesRegistrados);
                    break;
                case 2:


                case 3:

                    break;
                case 4:

                    break;
                case 5:
                    break;
            }
        } while (opcion < 1 || opcion > 5);

        return opcion;
    }
    static void NuevaInscripcion(Dictionary<int, string> ClientesRegistrados)
    {
        string dniIn = IngresarString("Ingrese su número de DNI");
        string apellidoIn = IngresarString("Ingrese su apellido");
        string nombreIn = IngresarString("Ingrese su nombre");
        int tipoEntradaIn;
        do
        {
            tipoEntradaIn = IngresarEntero("Ingrese el tipo de entrada que desea (del 1 al 4)");
        } while (tipoEntradaIn < 0 || tipoEntradaIn > 4);
        double valorAbonado;
        double[] valores = new double[4];
        valores[1] = 15000;
        valores[2] = 30000;
        valores[3] = 10000;
        valores[4] = 40000;

        do
        {
            valorAbonado = IngresarDouble("Ingrese el valor a abonar");
        } while (valorAbonado >= valores[tipoEntradaIn]);
        double vuelto;
        if (valorAbonado > valores[tipoEntradaIn])
        {
            vuelto = valorAbonado - valores[tipoEntradaIn];
        }
    }
    static int IngresarEntero(string msg)
    {
        Console.WriteLine(msg);
        return int.Parse(Console.ReadLine());
    }
    static double IngresarDouble(string msg)
    {
        Console.WriteLine(msg);
        return double.Parse(Console.ReadLine());
    }
    static string IngresarString(string msg)
    {
        Console.WriteLine(msg);
        return Console.ReadLine();
    }
}
