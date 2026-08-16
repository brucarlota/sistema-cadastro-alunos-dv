int opcao;

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
            break;

        case 2:
            Console.WriteLine("Opção selecionada: Buscar aluno");
            break;

        case 3:
            Console.WriteLine("Opção selecionada: Exibir aprovados");
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