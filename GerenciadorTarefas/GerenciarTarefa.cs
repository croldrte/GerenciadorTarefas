using Layout;
using Tarefas;

namespace GerenciarTarefa
{
    class GerenciadorTarefas
    {
        public static void AdicionarTarefa()
        {
            string descricao;
            Console.Clear();
            do
            {
                Console.Write("Digite a descrição da tarefa: ");
                descricao = Console.ReadLine();
                if (string.IsNullOrEmpty(descricao))
                {
                    Formatacao.Cor("Descrição não pode ficar vazia. Tente novamente.", ConsoleColor.Magenta);
                }
            } while (string.IsNullOrEmpty(descricao));
            Tarefa.listaDeTarefas.Add(new Tarefa { Id = Tarefa.listaDeTarefas.Count + 1, Descricao = descricao, Status = "[ ]" });
            Formatacao.Cor("Tarefa adicionada com sucesso!", ConsoleColor.Green);
            Console.WriteLine();
        }
        public static void ListarTarefas()
        {
            Console.Clear();
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
                Formatacao.Cor("Nenhuma tarefa adicionada.", ConsoleColor.Yellow);
            }
            Console.WriteLine();
        }
        public static void ConcluirTarefa()
        {
            int id;
            ListarTarefas();
            do
            {
                Console.Write("Digite o ID da tarefa a concluir: ");
                if (!int.TryParse(Console.ReadLine(), out id) || id <= 0 || id > Tarefa.listaDeTarefas.Count)
                {
                    Formatacao.Cor("ID não encontrado. Tente novamente.", ConsoleColor.Magenta);
                }
            } while (id <= 0 || id > Tarefa.listaDeTarefas.Count);
            Tarefa.listaDeTarefas[id - 1].Status = "[X]";
            Formatacao.Cor("Tarefa concluída!", ConsoleColor.Green);
            Console.WriteLine();
        }
        public static void RemoverTarefa()
        {
            int id;
            ListarTarefas();
            do
            {
                Console.Write("Digite o ID da tarefa a remover: ");
                if (!int.TryParse(Console.ReadLine(), out id) || id <= 0 || id > Tarefa.listaDeTarefas.Count)
                {
                    Formatacao.Cor("ID não encontrado. Tente novamente.", ConsoleColor.Magenta);
                }
            } while (id <= 0 || id > Tarefa.listaDeTarefas.Count);
            Tarefa.listaDeTarefas.RemoveAt(id - 1);
            Formatacao.Cor("Tarefa removida com sucesso!", ConsoleColor.Red);
            Console.WriteLine();
        }
    }
}