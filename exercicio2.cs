var numbers = new double[10];
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Digite o {0} número real: ", i + 1);
    numbers[i] = Convert.ToDouble(Console.ReadLine());
}
for (int i = 9; i >= 0; i--)
    Console.WriteLine(numbers[i]);

Console.ReadLine();