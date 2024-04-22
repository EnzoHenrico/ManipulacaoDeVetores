int[] numbers = new int[10];
int[] evens = new int[10];
int[] odds = new int[10];
int oddCount = 0, evenCount = 0;

for (int i = 0; i < 10; i++)
{
    Console.Write($"Numero {i + 1}: ");
    numbers[i] = int.Parse(Console.ReadLine());
    
    if (numbers[i] % 2 == 0)
    {
        evens[evenCount] = numbers[i];
        evenCount++;
    }
    else
    {
        odds[oddCount] = numbers[i];
        oddCount++;
    }
}

// 1o) Imprima o vetor lido
Console.Write("\n\nVetor lido:");
for (int i = 0; i < 10; i++)
{
    Console.Write(" " + numbers[i]);
}

// 2o) Imprima o vetor de traz pra frente
Console.Write("\n\nVetor invertido:");
for (int i = 9; i >= 0; i--)
{
    Console.Write(" " + numbers[i]);
}

// 3o) imprima até a metrade do vetor
Console.Write("\n\nVetor até a metade:");
for (int i = 0; i < 5; i++)
{
    Console.Write(" " + numbers[i]);
}

// 4o) Guarde e imprima os valores impares em um novo vetor (sem os valores 0)
Console.Write("\n\nValores impares:");
for (int i = 0; i < oddCount; i++)
{        
    Console.Write(" " + odds[i]);    
}

// 5o) Guarde e imprima os valores pares em um novo vetor (sem os valores 0)
Console.Write("\n\nValores pares:");
for (int i = 0; i < evenCount; i++)
{
    Console.Write(" " + evens[i]);
}

// Interação final
Console.WriteLine();
Console.ReadKey();