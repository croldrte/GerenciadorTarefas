using Layout;

namespace Tarefas
{
    public class Tarefa
    {
        public bool Concluida { get; set; }
        public int Id { get; set; }
        public string Descricao { get; set; }
        public Tarefa(int id, string descricao)
        {
            Id = id;
            Descricao = descricao;
            Concluida = false;
        }
        public void ExibirTarefa()
        {
            Formatacao.Cor($"{(Concluida ? "[X]" : "[ ]")} ID: {Id} – {Descricao}", ConsoleColor.Yellow);
        }
    }
}