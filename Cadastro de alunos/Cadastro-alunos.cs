// Sistema de Cadastro de Alunos
using System.Globalization;

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
				case 2:
						Console.WriteLine("\nUtilizar alunos do sistema...");
						nomes = ["Alice", "Bob", "Charlie", "Diana", "Ethan", "Fiona", "George", "Hannah", "Ian", "Julia"];
						idades = [20, 22, 21, 23, 19, 20, 22, 21, 23, 20];
						nota1 = [8.5, 2.0, 9.0, 8.0, 7.5, 8.5, 9.0, 8.0, 7.5, 8.5];
						nota2 = [8.0, 4.5, 8.5, 8.0, 7.0, 8.0, 8.5, 8.0, 7.5, 8.0];
						totalAlunos = MAX_ALUNOS;
						break;
				case 3:
						ExibirMenuPrincipal();
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


void BuscarAluno() 
{
    Console.WriteLine("== BUSCAR ALUNO ==");
    Console.WriteLine();

    Console.Write("Informe o nome do aluno: ");
    string nomeDigitado = Console.ReadLine().Trim();

    // Coloca primeira letra em maiúsculo de cada palavra depois da entrada
    string nome = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nomeDigitado);

    if (!nomes.Contains(nome))
    {
        Console.WriteLine();
        Console.WriteLine("Aluno não encontrado.");
        return;
    }

    int posicao = nomes.IndexOf(nome);

    Console.WriteLine("Aluno encontrado!");
    Console.WriteLine();
    Console.WriteLine($"Nome: {nomes[posicao]}");
    Console.WriteLine($"Idade: {idades[posicao]}");
    Console.WriteLine($"Nota 1: {nota1[posicao]}");
    Console.WriteLine($"Nota 2: {nota2[posicao]}");
    Console.WriteLine($"Média: {(nota1[posicao] + nota2[posicao]) / 2}");
}

void ExibirMenuPrincipal()
{
	do
	{
			Console.WriteLine();
			Console.WriteLine("===== MENU PRINCIPAL =====");
			Console.WriteLine("1 - Listar alunos");
			Console.WriteLine("2 - Buscar aluno");
			Console.WriteLine("3 - Exibir aprovados");
			Console.WriteLine("4 - Exibir média da turma");
			Console.WriteLine("0 - Encerrar");
			Console.Write("Escolha uma opção: ");

			opcao = int.Parse(Console.ReadLine());

			switch (opcao)
			{
					case 1:
							Console.WriteLine("Opção selecionada: Listar alunos");
                            ExibirListagemAlunos();
							break;

					case 2:
							Console.WriteLine("Opção selecionada: Buscar aluno");
                            BuscarAluno();
                            break;

					case 3:
							Console.WriteLine("Opção selecionada: Exibir aprovados");
							AlunosAprovados();
							break;

					case 4:
							Console.WriteLine("Opção selecionada: Exibir média da turma");
							break;

					case 0:
							Console.WriteLine("Encerrando o sistema...");
							break;

					default:
							Console.WriteLine("Opção inválida. Tente novamente.");
							break;
			}

	} while (opcao != 0);
}

void ExibirListagemAlunos()
{
    Console.WriteLine("\n--- Alunos Cadastrados ---\n");

    if (totalAlunos == 0)
    {
        Console.WriteLine("Nenhum aluno cadastrado ainda!");
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

void ExibirMenu()
{
    Console.Clear();
    Console.WriteLine("=========================================");
    Console.WriteLine("   SISTEMA DE CADASTRO DE ALUNOS");
    Console.WriteLine("=========================================");
    Console.WriteLine($"Alunos cadastrados: {totalAlunos}/{MAX_ALUNOS}");
    Console.WriteLine("-----------------------------------------");
    Console.WriteLine("1 - Cadastrar aluno");
    Console.WriteLine("2 - Utilizar alunos do sistema");
    Console.WriteLine("3 - Ir para o Menu principal");
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

void AlunosAprovados()
{
	int totalAlunosAprovados = 0;
	
	Console.WriteLine("\n--- Alunos Aprovados ---\n");

	for (int i = 0; i < nomes.Length; i++)
	{
			double media = (nota1[i] + nota2[i]) / 2;

			if (media >= 7.0)
			{
					Console.WriteLine($"{nomes[i]} - Média: {media:F1}");
					totalAlunosAprovados++;
			}
	}
	Console.WriteLine($"Total: {totalAlunosAprovados} alunos");
}
