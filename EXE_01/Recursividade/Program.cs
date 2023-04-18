Console.WriteLine("Cálculo Fatorial Recursivo");
Console.WriteLine("*********************************************");
Console.WriteLine();

Console.WriteLine("Digite um número:");
int numero = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Fatorial de {numero} é {Factorial(numero)}");
Console.WriteLine($"Fibonacci de {numero} é {Fibonacci(numero)}");


static int Factorial(int number)
{
    //caso base 1
    if(number < 0)
    {
        throw new ArgumentException(
            message: $"A função fatorial não suporta números negativos. Input {number}",
            paramName: nameof(number)
        );
    }
    else if(number == 0) //caso base 2
    {
        return 1;
    }
    else // Caso Recursivo
    {
        return number * Factorial(number -1);
    }
}

static long Fibonacci(int n)
{
    if( n <= 2L) // Caso base
        return 1L;

    return Fibonacci(n - 1) + Fibonacci(n - 2);
}

static void MultiplicarWhile(int n)
{
    int fator = 10;
    while(fator <=10)
    {
        Console.WriteLine($"{n} x {fator} = {n * fator}");
        fator++;
    }
}
