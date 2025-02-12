using Layout;

namespace Tarefas
{
    class Tarefa
    {
        public bool Concluido { get; set; }
        public int Id { get; set; }
        public string Descricao { get; set; }
        public static List<Tarefa> listaDeTarefas = new List<Tarefa>();
        public void ExibirTarefa()
        {
            Formatacao.Cor($"{(Concluido ? "[X]" : "[ ]")} ID: {Id} – {Descricao}", ConsoleColor.Yellow);
        }
    }
}