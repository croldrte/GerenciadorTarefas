using Layout;
using GerenciarTarefa;

bool entradaValida;
string opcao, descricao;
int id;

Console.Clear();
while (true)
{
    Formatacao.ImprimirCabecalho();
    Console.WriteLine("1 – Adicionar Tarefa");
    Console.WriteLine("2 – Listar Tarefas");
    Console.WriteLine("3 – Concluir Tarefa");
    Console.WriteLine("4 – Remover Tarefa");
    Console.WriteLine("0 – Sair");
    do
    {
        Console.Write("Escolha uma opção: ");
        opcao = Console.ReadLine();
        switch (opcao)
        {
            case "1":
                entradaValida = true;
                Console.Clear();
                do
                {
                    Console.Write("Digite a descrição da tarefa: ");
                    descricao = Console.ReadLine();
                    if (string.IsNullOrEmpty(descricao))
                        Formatacao.Cor("Descrição não pode ficar vazia. Tente novamente.", ConsoleColor.Magenta);
                } while (string.IsNullOrEmpty(descricao));
                GerenciadorTarefas.AdicionarTarefa(descricao);
                break;
            case "2":
                entradaValida = true;
                Console.Clear();
                GerenciadorTarefas.ListarTarefas();
                break;
            case "3":
                entradaValida = true;
                Console.Clear();
                GerenciadorTarefas.ListarTarefas();
                do
                {
                    Console.Write("Digite o ID da tarefa a concluir: ");
                    if (!int.TryParse(Console.ReadLine(), out id) || id <= 0 || id > GerenciadorTarefas.listaDeTarefas.Count)
                        Formatacao.Cor("ID não encontrado. Tente novamente.", ConsoleColor.Magenta);
                } while (id <= 0 || id > GerenciadorTarefas.listaDeTarefas.Count);
                GerenciadorTarefas.ConcluirTarefa(id);
                break;
            case "4":
                entradaValida = true;
                Console.Clear();
                GerenciadorTarefas.ListarTarefas();
                do
                {
                    Console.Write("Digite o ID da tarefa a remover: ");
                    if (!int.TryParse(Console.ReadLine(), out id) || id <= 0 || id > GerenciadorTarefas.listaDeTarefas.Count)
                        Formatacao.Cor("ID não encontrado. Tente novamente.", ConsoleColor.Magenta);
                } while (id <= 0 || id > GerenciadorTarefas.listaDeTarefas.Count);
                GerenciadorTarefas.RemoverTarefa(id);
                break;
            case "0":
                Console.WriteLine();
                Formatacao.Cor("Saindo...", ConsoleColor.Red);
                return;
            default:
                entradaValida = false;
                Formatacao.Cor("Opção inválida! Tente novamente.", ConsoleColor.Magenta);
                break;
        }
    } while (!entradaValida);
}