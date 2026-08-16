// Sistema de Cadastro de Alunos

// Quantidade máxima de alunos que o sistema permite cadastrar
const int MAX_ALUNOS = 10;

// Arrays paralelos: a posição "i" em cada array pertence ao mesmo aluno
string[] nomes = new string[MAX_ALUNOS];
int[] idades = new int[MAX_ALUNOS];
double[] nota1 = new double[MAX_ALUNOS];
double[] nota2 = new double[MAX_ALUNOS];

// Contador de quantos alunos já foram cadastrados de fato
int totalAlunos = 0;

int opcao;

do
{
    ExibirMenu();
    opcao = LerOpcaoMenu();

    switch (opcao)
    {
        case 1:
            CadastrarAluno();
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
    Console.WriteLine("   SISTEMA DE CADASTRO DE ALUNOS");
    Console.WriteLine("=========================================");
    Console.WriteLine($"Alunos cadastrados: {totalAlunos}/{MAX_ALUNOS}");
    Console.WriteLine("-----------------------------------------");
    Console.WriteLine("1 - Cadastrar aluno");
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

void CadastrarAluno()
{
    Console.WriteLine("\n--- Cadastro de Aluno ---");

    if (totalAlunos >= MAX_ALUNOS)
    {
        Console.WriteLine("Não é possível cadastrar mais alunos. Limite de 10 atingido!");
        return;
    }

    int indice = totalAlunos;

    Console.Write("Nome do aluno: ");
    nomes[indice] = Console.ReadLine();

    idades[indice] = LerNumeroInteiro("Idade: ");
    nota1[indice] = LerNumeroDecimal("Nota 1: ");
    nota2[indice] = LerNumeroDecimal("Nota 2: ");

    totalAlunos++;

    Console.WriteLine($"\nAluno \"{nomes[indice]}\" cadastrado com sucesso!");
}

void ListarAlunos()
{
    Console.WriteLine("\n--- Lista de Alunos ---");

    if (totalAlunos == 0)
    {
        Console.WriteLine("Nenhum aluno cadastrado ainda.");
        return;
    }

    for (int i = 0; i < totalAlunos; i++)
    {
        Console.WriteLine($"\nAluno {i + 1}");
        Console.WriteLine($"  Nome:   {nomes[i]}");
        Console.WriteLine($"  Idade:  {idades[i]}");
        Console.WriteLine($"  Nota 1: {nota1[i]:F1}");
        Console.WriteLine($"  Nota 2: {nota2[i]:F1}");
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