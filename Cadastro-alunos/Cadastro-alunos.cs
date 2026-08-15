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


// Mostra as opções disponíveis para o usuário
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

// Lê a opção digitada pelo usuário, validando se é um número
int LerOpcaoMenu()
{
    string entrada = Console.ReadLine();

    if (int.TryParse(entrada, out int opcaoLida))
        return opcaoLida;

    // Retorna um valor inválido caso o usuário digite um número inexistente ou um texto
    return -1;
}

// Cadastra um novo aluno nos arrays, se ainda houver espaço disponível
void CadastrarAluno()
{
    Console.WriteLine("\n--- Cadastro de Aluno ---");

    if (totalAlunos >= MAX_ALUNOS)
    {
        Console.WriteLine("Não é possível cadastrar mais alunos. Limite de 10 atingido!");
        return;
    }

    // A próxima posição livre nos arrays é o índice "totalAlunos"
    int indice = totalAlunos;

    Console.Write("Nome do aluno: ");
    nomes[indice] = Console.ReadLine();

    idades[indice] = LerNumeroInteiro("Idade: ");
    nota1[indice] = LerNumeroDecimal("Nota 1: ");
    nota2[indice] = LerNumeroDecimal("Nota 2: ");

    // Só incrementa o total depois que todos os dados foram preenchidos
    totalAlunos++;

    Console.WriteLine($"\nAluno \"{nomes[indice]}\" cadastrado com sucesso!");
}

//Lê um número inteiro do usuário, repetindo a pergunta até que a entrada seja válida
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

// Lê um número decimal do usuário, repetindo a pergunta até que a entrada seja válida
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