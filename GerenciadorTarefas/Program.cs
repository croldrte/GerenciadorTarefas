using Layout;
using GerenciarTarefa;

Console.Clear();
menu:
Formatacao.ImprimirCabecalho();
Console.WriteLine("1 – Adicionar Tarefa");
Console.WriteLine("2 – Listar Tarefas");
Console.WriteLine("3 – Concluir Tarefa");
Console.WriteLine("4 – Remover Tarefa");
Console.WriteLine("0 – Sair");
Console.Write("Escolha uma opção: ");
string opcao = Console.ReadLine();
switch (opcao)
{
    case "1":
        GerenciadorTarefas.AdicionarTarefa();
        break;
    case "2":
        break;
    case "3":
        break;
    case "4":
        break;
    case "0":
        Formatacao.Cor("Saindo...", ConsoleColor.Red);
        return;
}
goto menu;