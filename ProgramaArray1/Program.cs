internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            // Crear una matriz de 20 elementos
            int[] array = new int[21];

            // Inicializar la matriz con valores según el índice multiplicado por 5
            for (int i = 1; i < array.Length; i++)
            {
                array[i] = i * 5;
            }

            // Imprimir los elementos de la matriz
            Console.WriteLine("Elementos de la matriz:");
            for (int i = 1; i < array.Length; i++)
            {
                Console.WriteLine($"Índice {i}: {array[i]}");
            }

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }
}