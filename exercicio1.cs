var lista = new int[5];
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Digite um número inteiro: ");
    lista[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < 5; i++)
    Console.WriteLine("O {0} número é {1}", i + 1, lista[i]);

Console.ReadLine();
