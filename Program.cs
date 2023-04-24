internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<int, string> ClientesRegistrados = new Dictionary<int, string>();
    }
    static int Menu(Dictionary<int, string> ClientesRegistrados)
    {
        List<double> RecaudacionPorDia = new List<double>();
        List<int> CantidadEntradas = new List<int>();
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
                    NuevaInscripcion(ClientesRegistrados, RecaudacionPorDia, CantidadEntradas);
                    break;
                case 2:
                    ObtenerEstadisticas(ClientesRegistrados, RecaudacionPorDia, CantidadEntradas);
                    break;
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
    static void NuevaInscripcion(Dictionary<int, string> ClientesRegistrados, List<double> RecaudacionPorDia, List<int> CantidadEntradas)
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
        valores[0] = 15000;
        valores[1] = 30000;
        valores[2] = 10000;
        valores[3] = 40000;

        double suma = 0;
        int cantSuma = 0;
        if (tipoEntradaIn == 1)
        {
            cantSuma = CantidadEntradas[0] + 1;
            CantidadEntradas.Insert(0, cantSuma);
            suma = RecaudacionPorDia[0] + valores[0];
            RecaudacionPorDia.Insert(0, suma);
        }
        else if (tipoEntradaIn == 2)
        {
            cantSuma = CantidadEntradas[1] + 1;
            CantidadEntradas.Insert(1, cantSuma);
            suma = 0;
            suma = RecaudacionPorDia[1] + valores[1];
            RecaudacionPorDia.Insert(1, suma);
        }
        else if (tipoEntradaIn == 3)
        {
            cantSuma = CantidadEntradas[2] + 1;
            CantidadEntradas.Insert(2, cantSuma);
            suma = RecaudacionPorDia[2] + valores[2];
            RecaudacionPorDia.Insert(2, suma);
        }
        else if (tipoEntradaIn == 4)
        {
            cantSuma = CantidadEntradas[3] + 1;
            CantidadEntradas.Insert(3, cantSuma);
            suma = RecaudacionPorDia[0] + valores[3];
            RecaudacionPorDia.Insert(0, suma);
            suma = RecaudacionPorDia[1] + valores[3];
            RecaudacionPorDia.Insert(1, suma);
            suma = RecaudacionPorDia[2] + valores[3];
            RecaudacionPorDia.Insert(2, suma);
        }
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
    static void ObtenerEstadisticas(Dictionary<int, string> ClientesRegistrados, List<double> RecaudacionPorDia, List<int> CantidadEntradas)
    {
        int i = 0; // Cantidad de clientes registrados
        foreach (int clave in ClientesRegistrados.Keys)
        {
            i++;
        }
        Console.WriteLine("Cantidad de clientes inscriptos: " + i);
        // Porcentajes
        int cantTotal = CantidadEntradas[0] + CantidadEntradas[1] + CantidadEntradas[2] + CantidadEntradas[3];
        Console.WriteLine("Porcentaje de entradas del día uno respecto al total" + (CantidadEntradas[0] * cantTotal) / 100);
        Console.WriteLine("Porcentaje de entradas del día dos respecto al total" + (CantidadEntradas[1] * cantTotal) / 100);
        Console.WriteLine("Porcentaje de entradas del día tres respecto al total" + (CantidadEntradas[2] * cantTotal) / 100);
        Console.WriteLine("Porcentaje de entradas del full pass respecto al total" + (CantidadEntradas[3] * cantTotal) / 100);
    Console.WriteLine("Recaudación del día 1: " + RecaudacionPorDia[0]);
    Console.WriteLine("Recaudación del día 2: " + RecaudacionPorDia[1]);
    Console.WriteLine("Recaudación del día 3: " + RecaudacionPorDia[2]);
    double recaudacionTotal = RecaudacionPorDia[0] + RecaudacionPorDia[1] + RecaudacionPorDia[2];
    Console.WriteLine("Recaudación total: " + recaudacionTotal);
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
