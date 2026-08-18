using System.Globalization;

string[] nomeAlunos = new string[];

Console.WriteLine("== BUSCAR ALUNO ==");
Console.WriteLine();

Console.Write("Informe o nome do aluno: ");
string nomeDigitado = Console.ReadLine().Trim();

// Coloca primeira letra em maiúsculo de cada palavra depois da entrada
string nome = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nomeDigitado);

if (!nomeAlunos.Contains(nome))
{
    Console.WriteLine();
    Console.WriteLine("Aluno não encontrado.");
    return;
}

int posicao = nomeAlunos.IndexOf(nome);

Console.WriteLine("Aluno encontrado!");
Console.WriteLine();
Console.WriteLine($"Nome: {nomeAlunos[posicao]}");
Console.WriteLine($"Idade: ");
Console.WriteLine($"Nota 1: ");
Console.WriteLine($"Nota 2: ");
Console.WriteLine($"Média: ");