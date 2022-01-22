
try
{

    Console.WriteLine("\n\nCalculadora de Perimetro de cualquier poligono regular");
    Console.WriteLine("----------------------------------------------------------\n\n");

    Console.WriteLine("Escriba la cantidad de lados que tiene el poligono: ");
    var NumeroDeLados = int.Parse(Console.ReadLine());


    Console.WriteLine("Escriba la medida de uno de sus lados: ");
    var MedidaDeUnLado = int.Parse(Console.ReadLine());


    var Result = CalculadorDePerimetros(NumeroDeLados, MedidaDeUnLado);
    Console.WriteLine("\nPerimetro = " + Result);

    int CalculadorDePerimetros(int n, int l)
    {

        int resultado = 0;
        for (int s = 0; s < n; s++)
        {
            resultado += l;
        }

        return resultado;
    }


}
catch (Exception e)
{
    Console.WriteLine(e.Message);
    Console.WriteLine("Saliendo...");
}
