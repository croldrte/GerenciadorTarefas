using Layout;
using Tarefas;

namespace GerenciarTarefa
{
    class GerenciadorTarefas
    {
        public static List<Tarefa> listaDeTarefas = new List<Tarefa>();
        public static void AdicionarTarefa(string descricao)
        {
            listaDeTarefas.Add(new Tarefa(descricao));
            Formatacao.Cor("Tarefa adicionada com sucesso!", ConsoleColor.Green);
            Console.WriteLine();
        }
        public static void ListarTarefas()
        {
            if (listaDeTarefas.Count > 0)
            {
                Console.WriteLine("Tarefas:");
                foreach (var tarefa in listaDeTarefas)
                    tarefa.ExibirTarefa();
            }
            else
            {
                Formatacao.Cor("Nenhuma tarefa adicionada.", ConsoleColor.Yellow);
            }
            Console.WriteLine();
        }
        public static void ConcluirTarefa(int id)
        {
            listaDeTarefas[id - 1].Concluida = true;
            Formatacao.Cor("Tarefa concluída!", ConsoleColor.Green);
            Console.WriteLine();
        }
        public static void RemoverTarefa(int id)
        {
            listaDeTarefas.RemoveAt(id - 1);
            Formatacao.Cor("Tarefa removida com sucesso!", ConsoleColor.Red);
            Console.WriteLine();
        }
    }
}