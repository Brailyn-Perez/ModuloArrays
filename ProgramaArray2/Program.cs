internal class Program
{
    private static void Main(string[] args)
    {
        int size;
        string ValorIntroducidoPorConsola = String.Empty;
        try
        {
            // Leer la longitud de las matrices
            Console.Write("Ingrese el tamaño de las matrices: ");
            ValorIntroducidoPorConsola = Console.ReadLine();

            if (string.IsNullOrEmpty(ValorIntroducidoPorConsola) || string.IsNullOrWhiteSpace(ValorIntroducidoPorConsola))
            {
                Console.WriteLine("No se admiten datos vacios");
            }
            else
            {
                if (int.TryParse(ValorIntroducidoPorConsola, out size))
                {
                    // Crear dos matrices de enteros
                    int[] matrix1 = new int[size];
                    int[] matrix2 = new int[size];

                    // Leer los elementos de la primera matriz
                    Console.WriteLine("Ingrese los elementos de la primera matriz:");
                    for (int i = 0; i < size; i++)
                    {
                        Console.Write($"Elemento {i + 1}: ");
                        matrix1[i] = int.Parse(Console.ReadLine());
                    }

                    // Leer los elementos de la segunda matriz
                    Console.WriteLine("Ingrese los elementos de la segunda matriz:");
                    for (int i = 0; i < size; i++)
                    {
                        Console.Write($"Elemento {i + 1}: ");
                        matrix2[i] = int.Parse(Console.ReadLine());
                    }

                    // Verificar si las matrices son iguales
                    bool areEqual = true;
                    for (int i = 0; i < size; i++)
                    {
                        if (matrix1[i] != matrix2[i])
                        {
                            areEqual = false;
                            break;
                        }
                    }

                    // Imprimir el resultado
                    if (areEqual)
                    {
                        Console.WriteLine("Las matrices son iguales.");
                    }
                    else
                    {
                        Console.WriteLine("Las matrices no son iguales.");
                    }
                }
                else
                {
                    Console.WriteLine("No introdujo un valor numerico");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }





    }
}