
try
{

    Console.WriteLine("\n\nConversor de Divisa");
    Console.WriteLine("-----------------------\n\n");
    int opcion = 0;
   // do
   // {
        if (opcion == 0)
        {
            Console.WriteLine("Seleccione una opcion:\n");
        }
        else
        {
            Console.WriteLine("Seleccione una opcion valida:\n");
        }

        Console.WriteLine("1. Dolares a Euros");
        Console.WriteLine("2. Euros a Dolares");
        opcion = int.Parse(Console.ReadLine());

    //} while (opcion == 1 || opcion == 2);


    switch (opcion)
    {
        case 1:
            Console.WriteLine("\nCantidad de Euros =" + ConversorDolarEuro());
            break;
        case 2:
            Console.WriteLine("\nCantidad de Dolares =" + ConversorEuroDolar());
            break;
        default:
            Console.WriteLine("\n Opcion invalida \nSaliendo...");
            return;
    }

    double ConversorDolarEuro()
    {
        Console.WriteLine("\nEscriba la tasa de cambio de la forma (1 Dolar a Euros): ");
        var tasa = double.Parse(Console.ReadLine());

        Console.WriteLine("\nEscriba la cantidad de Dolares a cambiar: ");
        var cantidad = double.Parse(Console.ReadLine());

        return (cantidad * tasa);

    }

    double ConversorEuroDolar()
    {
        Console.WriteLine("Escriba la tasa de cambio de la forma (1 Euro a Dolares): ");
        var tasa = double.Parse(Console.ReadLine());

        Console.WriteLine("Escriba la cantidad de Euros a cambiar: ");
        var cantidad = double.Parse(Console.ReadLine());

        return (cantidad * tasa);

    }
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
    Console.WriteLine("Saliendo...");
}
