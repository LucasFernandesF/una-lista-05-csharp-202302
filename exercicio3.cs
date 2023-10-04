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