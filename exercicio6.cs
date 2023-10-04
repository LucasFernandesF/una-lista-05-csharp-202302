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