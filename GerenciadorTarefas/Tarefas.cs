using Layout;

namespace Tarefas
{
    class Tarefa
    {
        public string Status { get; set; }
        public int Id { get; set; }
        public string Descricao { get; set; }
        public static List<Tarefa> listaDeTarefas = new List<Tarefa>();
        public void ExibirTarefa()
        {
            Formatacao.Cor($"{Status} ID: {Id} – {Descricao}", ConsoleColor.Yellow);
        }
    }
}