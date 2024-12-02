internal class Program
{
    private static void Main(string[] args)
    {
        int n;
        string ValorIngresadoPorConsola = String.Empty;
        try
        {
            // Solicitar al usuario cuántos números va a ingresar
            Console.Write("Ingrese la cantidad de números a ingresar: ");
            ValorIngresadoPorConsola = Console.ReadLine();

            if (string.IsNullOrEmpty(ValorIngresadoPorConsola) || string.IsNullOrWhiteSpace(ValorIngresadoPorConsola))
            {
                Console.WriteLine("No se permiten datos vacios o nulos");
            }
            else
            {
                if (int.TryParse(ValorIngresadoPorConsola, out n))
                {
                    // Crear un arreglo para almacenar los números
                    int[] numbers = new int[n];

                    // Solicitar los números al usuario
                    Console.WriteLine("Ingrese los números:");
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write($"Número {i + 1}: ");
                        numbers[i] = int.Parse(Console.ReadLine());
                    }

                    // Determinar el menor valor
                    int minValue = numbers.Min();

                    // Verificar si algún valor se repite
                    bool hasDuplicates = numbers.GroupBy(x => x).Any(g => g.Count() > 1);

                    // Imprimir los resultados
                    Console.WriteLine($"\nEl menor valor es: {minValue}");
                    if (hasDuplicates)
                    {
                        Console.WriteLine("Al menos un valor se repite.");
                    }
                    else
                    {
                        Console.WriteLine("No hay valores repetidos.");
                    }
                }
                else
                {
                    Console.WriteLine("El tipo de dato no es numerico");
                }
            }

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }


    }
}