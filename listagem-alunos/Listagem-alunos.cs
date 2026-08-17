// Sistema de listagem de Alunos

const int MAX_ALUNOS = 10;

string[] nomes = new string[MAX_ALUNOS];
int[] idades = new int[MAX_ALUNOS];
double[] nota1 = new double[MAX_ALUNOS];
double[] nota2 = new double[MAX_ALUNOS];

int totalAlunos = 0;

int opcao;

do
{
    ExibirMenu();
    opcao = LerOpcaoMenu();

    switch (opcao)
    {
        case 1:
            ExibirAlunos();
            break;
        case 0:
            Console.WriteLine("\nEncerrando o sistema...");
            break;
        default:
            Console.WriteLine("\nOpção inválida! Tente novamente.");
            break;
    }

    if (opcao != 0)
    {
        Console.WriteLine("\nPressione ENTER para continuar...");
        Console.ReadLine();
    }

} while (opcao != 0);


void ExibirMenu()
{
    Console.Clear();
    Console.WriteLine("=========================================");
    Console.WriteLine("   SISTEMA DE LISTAGEM DE ALUNOS");
    Console.WriteLine("=========================================");
    Console.WriteLine("1 - Exibir alunos cadastrados");
    Console.WriteLine("0 - Sair");
    Console.WriteLine("=========================================");
    Console.Write("Escolha uma opção: ");
}

int LerOpcaoMenu()
{
    string entrada = Console.ReadLine();

    if (int.TryParse(entrada, out int opcaoLida))
        return opcaoLida;

    return -1;
}
void ExibirAlunos()
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

int LerNumeroInteiro(string mensagem)
{
    int valor;
    Console.Write(mensagem);

    while (!int.TryParse(Console.ReadLine(), out valor))
    {
        Console.Write("Valor inválido! Digite um número inteiro: ");
    }

    return valor;
}

double LerNumeroDecimal(string mensagem)
{
    double valor;
    Console.Write(mensagem);

    while (!double.TryParse(Console.ReadLine(), out valor))
    {
        Console.Write("Valor inválido! Digite um número (ex: 7.5): ");
    }

    return valor;
}