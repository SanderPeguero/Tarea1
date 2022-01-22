
try
{

    Console.WriteLine("\n\nConversor de Grados a Radianes");
    Console.WriteLine("----------------------------------\n\n");

    Console.WriteLine("Escriba los grados: ");
    var Grados = double.Parse(Console.ReadLine());

    double Conversor(double grados)
    {

        return (grados * (3.1416 / 180));
    }

    Console.WriteLine("\n\nRadianes = " + Conversor(Grados));

}
catch (Exception e)
{
    Console.WriteLine(e.Message);
    Console.WriteLine("Saliendo...");
}
