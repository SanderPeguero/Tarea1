
try
{

    Console.WriteLine("\n\nDeterminador de Dias de la Semana");
    Console.WriteLine("-------------------------------------\n\n");

    Console.WriteLine("Ingrese un Numero: ");
    var Numero = int.Parse(Console.ReadLine());

    switch (Numero)
    {
        case 1:
            Console.WriteLine("Lunes");
            break;
        case 2:
            Console.WriteLine("Martes");
            break;
        case 3:
            Console.WriteLine("Miercoles");
            break;
        case 4:
            Console.WriteLine("Jueves");
            break;
        case 5:
            Console.WriteLine("Viernes");
            break;
        case 6:
            Console.WriteLine("Sabado");
            break;
        case 7:
            Console.WriteLine("Domingo");
            break;
        default:
            Console.WriteLine("Opcion invalida\n Saliendo...\n");
            break;

    }

}
catch (Exception e)
{
    Console.WriteLine(e.Message);
    Console.WriteLine("Saliendo...");
}
