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
            Tarefa.listaDeTarefas.Add(new Tarefa { Id = Tarefa.listaDeTarefas.Count + 1, Descricao = descricao });
            Formatacao.Cor("Tarefa adicionada com sucesso!", ConsoleColor.Green);
        }
    }
}