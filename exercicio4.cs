var letras = new string[10];
int consoantes = 0;
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Digite o {0} caractere: ", i + 1);
    letras[i] = Console.ReadLine();
}
for (int i = 0; i < 10; i++)
{
    if (letras[i] != "a" && letras[i] != "e" && letras[i] != "i" && letras[i] != "o" && letras[i] != "u")
    {
        consoantes++;
        Console.WriteLine(letras[i]);
    }
}
Console.WriteLine("O número total de consoantes é " + consoantes);

Console.ReadLine();
