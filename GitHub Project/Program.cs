using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um número: ");
        double num = Convert.ToDouble(Console.ReadLine());
        Console.Write("Digite outro número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double result = num + num2;
        Console.WriteLine($"A soma dos números é {result}.");


        if (num2 > num) Console.WriteLine($"O numero {num2} é maior");

        Console.ReadKey();
    }
}
