// Sistema de listagem de Alunos

void ExibirListagemAlunos()
{
    Console.WriteLine("\n--- Alunos Cadastrados ---\n");

    if (totalAlunos == 0)
    {
        Console.WriteLine("Nenhum aluno cadastrado ainda.");
        return;
    }

    for (int i = 0; i < totalAlunos; i++)
    {
        double media = (nota1[i] + nota2[i]) / 2.0;

        Console.WriteLine($"Nome: {nomes[i]}");
        Console.WriteLine($"Idade: {idades[i]}");
        Console.WriteLine($"Média: {media:F1}");
        Console.WriteLine("-------------------------");
    }
}

