
try
{

    Console.WriteLine("\n\nComprobador de numero Par o Impar");
    Console.WriteLine("-----------------------\n\n");
    
    Console.WriteLine("Ingrese un Numero: ");
    var Numero = int.Parse(Console.ReadLine());

    
    string Comprobador()
    {
        string result = "null";
        
        if(Numero%2 == 0){
            result = "true";
        }else{
            result = "false";
        }

        return result;

    }

    switch (Comprobador()){
        case "true":
            Console.WriteLine("El numero es par");
            break;
        case "false":
            Console.WriteLine("El numero es impar");
            break;

    }

}
catch (Exception e)
{
    Console.WriteLine(e.Message);
    Console.WriteLine("Saliendo...");
}
