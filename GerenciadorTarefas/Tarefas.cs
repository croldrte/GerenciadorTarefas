using Layout;

namespace Tarefas
{
    class Tarefa
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public static List<Tarefa> listaDeTarefas = new List<Tarefa>();        
        public void ExibirTarefa()
        {
            Formatacao.Cor($"ID: {Id} – {Descricao}", ConsoleColor.Yellow);
        }
    }
}