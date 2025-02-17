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
            if (listaDeTarefas.Any())
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
            var tarefa = listaDeTarefas.Find(t => t.Id == id);
            if (tarefa != null)
            {
                tarefa.Concluida = true;
                Formatacao.Cor("Tarefa concluída!", ConsoleColor.Green);
            }
            else
            {
                Formatacao.Cor("ID não encontrado. Tente novamente.", ConsoleColor.Magenta);
            }
            Console.WriteLine();
        }
        public static void RemoverTarefa(int id)
        {
            var tarefa = listaDeTarefas.Find(t => t.Id == id);
            if (tarefa != null)
            {
                listaDeTarefas.Remove(tarefa);
                Formatacao.Cor("Tarefa removida com sucesso!", ConsoleColor.Red);
            }
            else
            {
                Formatacao.Cor("ID não encontrado. Tente novamente.", ConsoleColor.Magenta);
            }
            Console.WriteLine();
        }
    }
}