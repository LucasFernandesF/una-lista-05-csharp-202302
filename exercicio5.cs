var numeros = new int[20];
var pares = new int[20];
var impares = new int[20];

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine("Digite o {0} número inteiro: ", i + 1);
    numeros[i] = Convert.ToInt32(Console.ReadLine());
    if (numeros[i] % 2 == 0)
        pares[i] = numeros[i];
    else
        impares[i] = numeros[i];
}

for (int i = 0; i < numeros.Length; i++)
    Console.WriteLine("Os números inteiros digitados " + numeros[i]);

for (int i = 0; i < pares.Length; i++)
{
    if (pares[i] != 0)
        Console.WriteLine("Os números pares digitados " + pares[i]);
}

for (int i = 0; i < impares.Length; i++)
{
    if (impares[i] != 0)
        Console.WriteLine("Os números ímpares digitados " + impares[i]);
}

Console.ReadLine();