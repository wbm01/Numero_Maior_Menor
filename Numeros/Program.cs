internal class Program
{
    private static void Main(string[] args)
    {
        float maior = 0, menor = 0;
        float[] numero = new float[15]; //vetor
        int contador = 0;

        do
        {
            Console.Write("Informe {0}o número ", contador + 1);
            numero[contador] = float.Parse(Console.ReadLine());
            contador++;

        } while (contador < 15);

        maior = numero[0];
        menor = numero[0];

        for(contador = 0;  contador < 15; contador++)
        {
            if (maior < numero[contador])
            {
                maior = numero[contador];
            }
            
        }

        for (contador = 0; contador < 15; contador++)
        {
            if (menor > numero[contador])
            {
                menor = numero[contador];
            }

        }

        Console.WriteLine("\nO maior valor é: {0}", maior);
        Console.WriteLine("\nO menor valor é: {0}", menor);
    }
}