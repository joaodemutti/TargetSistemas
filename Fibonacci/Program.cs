
Console.WriteLine("Insira um número:");

int num;
num = int.Parse(Console.ReadLine());

int a = 0, b = 1, soma = 0;
Console.Write($"{a} ");

while (soma < num)
{
    Console.Write($"{b} ");
    soma = a + b;
    a = b;
    b = soma;
}
Console.WriteLine($"{soma}");

if (soma == num)
    Console.WriteLine("Pertence à sequência Fibonacci");
else
    Console.WriteLine("Não perntece à sequência Fibonacci");