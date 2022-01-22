try
{

    Console.WriteLine("\n\nConversor de Grados Centigrados a Grados Farenheit");
    Console.WriteLine("----------------------------------\n\n");

    Console.WriteLine("Escriba la temperatura en centigrados: ");
    var Grados = double.Parse(Console.ReadLine());

    double Conversor(double grados)
    {

        return ((grados * 9/5) + 32);

    }

    Console.WriteLine("\n\nFarenheit = " + Conversor(Grados));

}
catch (Exception e)
{
    Console.WriteLine(e.Message);
    Console.WriteLine("Saliendo...");
}
