# una-lista-05-csharp-202302

## Lucas Fernandes Firmino 622122322  

### 1 -  Faça um Programa que leia um vetor de 5 números inteiros e mostre-os.
```
var lista = new int[5];

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Digite um número inteiro: ");
    lista[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < 5; i++)
    Console.WriteLine("O {0} número é {1}", i + 1, lista[i]);

Console.ReadLine();
```
### 2 - Faça um Programa que leia um vetor de 10 números reais e mostre-os na ordem inversa.
```
var numbers = new double[10];

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Digite o {0} número real: ", i + 1);
    numbers[i] = Convert.ToDouble(Console.ReadLine());
}
for (int i = 9; i >= 0; i--)
    Console.WriteLine(numbers[i]);

Console.ReadLine();
```
### 3 - Faça um Programa que leia 4 notas, mostre as notas e a média na tela.
```
double media, soma = 0;
var notas = new double[4];

for (int i = 0; i < 4; i++)
{
    Console.WriteLine("Digite sua {0} nota: ", i + 1);
    notas[i] = Convert.ToDouble(Console.ReadLine());
}
for (int i = 0; i < 4; i++)
{
    soma = notas[i] + soma;
    Console.WriteLine("A {0} nota é {1}", i + 1, notas[i]);
}
media = soma / 4;
Console.WriteLine("A media das notas é " + media);

Console.ReadLine();
```
### 4 - Faça um Programa que leia um vetor de 10 caracteres, e diga quantas consoantes foram lidas. Imprima as consoantes.
```
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
```
### 5. Faça um Programa que leia 20 números inteiros e armazene-os num vetor. Armazene os números pares no vetor PAR e os números IMPARES no vetor ímpar. Imprima os três vetores.
```  
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
```
### 6 - Faça um Programa que peça as quatro notas de 10 alunos, calcule e armazene numvetor a média de cada aluno, imprima o número de alunos com média maior ou igual a 7.0. 
```
var media = new double[10];
int mediaMaiorSete = 0;

for (int i = 0; i < 10; i++)
{
    double notas = 0;
    Console.WriteLine("Digites as 4 notas do {0} aluno", i + 1);
    for (int j = 0; j < 4; j++)
    {
        Console.WriteLine("A {0} nota: ", j + 1);
        notas += Convert.ToDouble(Console.ReadLine());
    }
    media[i] = notas / 4;
    if (media[i] >= 7)
        mediaMaiorSete++;
}
Console.WriteLine("O número de alunos com a nota maior ou igual a sete é "+mediaMaiorSete);
for (int i = 0; i < 10; i++)
    Console.WriteLine("Media do aluno {0}: {1}",i + 1,media[i]);

Console.ReadLine();
```
