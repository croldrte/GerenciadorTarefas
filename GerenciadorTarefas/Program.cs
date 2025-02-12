using Layout;
using GerenciarTarefa;

bool entradaValida;

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
        string opcao = Console.ReadLine();
        switch (opcao)
        {
            case "1":
                entradaValida = true;
                GerenciadorTarefas.AdicionarTarefa();
                break;
            case "2":
                entradaValida = true;
                GerenciadorTarefas.ListarTarefas();
                break;
            case "3":
                entradaValida = true;
                GerenciadorTarefas.ConcluirTarefa();
                break;
            case "4":
                entradaValida = true;
                GerenciadorTarefas.RemoverTarefa();
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