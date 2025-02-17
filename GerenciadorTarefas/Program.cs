using Layout;
using GerenciarTarefa;

string descricao;
int opcao, id;

Console.Clear();
while (true)
{
    Formatacao.ImprimirCabecalho();
    Console.WriteLine("1 – Adicionar Tarefa");
    Console.WriteLine("2 – Listar Tarefas");
    Console.WriteLine("3 – Concluir Tarefa");
    Console.WriteLine("4 – Remover Tarefa");
    Console.WriteLine("0 – Sair");

    while (true)
    {
        Console.Write("Escolha uma opção: ");
        if (int.TryParse(Console.ReadLine(), out opcao) && opcao >= 0 && opcao <= 4)
            break;
        else
            Formatacao.Cor("Opção inválida! Tente novamente.", ConsoleColor.Magenta);
    }

    switch (opcao)
    {
        case 1:
            Console.Clear();
            while (true)
            {
                Console.Write("Digite a descrição da tarefa: ");
                descricao = Console.ReadLine();
                if (!string.IsNullOrEmpty(descricao))
                    break;
                Formatacao.Cor("Descrição não pode ficar vazia. Tente novamente.", ConsoleColor.Magenta);
            }
            GerenciadorTarefas.AdicionarTarefa(descricao);
            break;

        case 2:
            Console.Clear();
            GerenciadorTarefas.ListarTarefas();
            break;

        case 3:
            Console.Clear();
            GerenciadorTarefas.ListarTarefas();
            if (GerenciadorTarefas.listaDeTarefas.Any())
            {
                while (true)
                {
                    Console.Write("Digite o ID da tarefa a concluir: ");
                    if (int.TryParse(Console.ReadLine(), out id) && id > 0 && id <= GerenciadorTarefas.listaDeTarefas.LastOrDefault().Id)
                    {
                        GerenciadorTarefas.ConcluirTarefa(id);
                        break;
                    }
                    Formatacao.Cor("ID não encontrado. Tente novamente.", ConsoleColor.Magenta);
                }
            }
            else
            {
                Formatacao.Cor("Adicione tarefas antes de tentar conclui-las.", ConsoleColor.Magenta);
                Console.WriteLine();
            }
            break;

        case 4:
            Console.Clear();
            GerenciadorTarefas.ListarTarefas();
            if (GerenciadorTarefas.listaDeTarefas.Any())
            {
                while (true)
                {
                    Console.Write("Digite o ID da tarefa a remover: ");
                    if (int.TryParse(Console.ReadLine(), out id) && id > 0 && id <= GerenciadorTarefas.listaDeTarefas.LastOrDefault().Id)
                    {
                        GerenciadorTarefas.RemoverTarefa(id);
                        break;
                    }
                    Formatacao.Cor("ID não encontrado. Tente novamente.", ConsoleColor.Magenta);
                }
            }
            else
            {
                Formatacao.Cor("Adicione tarefas antes de tentar removê-las.", ConsoleColor.Magenta);
                Console.WriteLine();
            }
            break;

        case 0:
            Console.WriteLine();
            Formatacao.Cor("Saindo...", ConsoleColor.Red);
            return;
    }
}