using Layout;
using Tarefas;

namespace GerenciarTarefa
{
    class GerenciadorTarefas
    {
        public static void AdicionarTarefa()
        {
            Console.Write("Digite a descrição da tarefa: ");
            string descricao = Console.ReadLine();
            Tarefa.listaDeTarefas.Add(new Tarefa { Id = Tarefa.listaDeTarefas.Count + 1, Descricao = descricao, Status = "[ ]" });
            Formatacao.Cor("Tarefa adicionada com sucesso!", ConsoleColor.Green);
        }
        public static void ListarTarefas()
        {
            if (Tarefa.listaDeTarefas.Count > 0)
            {
                Formatacao.Cor("Tarefas:", ConsoleColor.Yellow);
                foreach (var tarefa in Tarefa.listaDeTarefas)
                {
                    tarefa.ExibirTarefa();
                }
            }
            else
            {
                Formatacao.Cor("Nenhuma tarefa adicionada.", ConsoleColor.Red);
            }
        }
        public static void ConcluirTarefa()
        {
            ListarTarefas();
            Console.Write("Digite o ID da tarefa a concluir: ");
            int id = int.Parse(Console.ReadLine());
            Tarefa.listaDeTarefas[id - 1].Status = "[X]";
            Formatacao.Cor("Tarefa concluída!", ConsoleColor.Green);
        }
    }
}