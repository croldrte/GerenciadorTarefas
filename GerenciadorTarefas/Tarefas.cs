using Layout;
using GerenciarTarefa;

namespace Tarefas
{
    public class Tarefa
    {
        public bool Concluida { get; set; }
        public int Id { get; set; }
        public string Descricao { get; set; }
        public Tarefa(string descricao)
        {
            Concluida = false;
            Id = GerenciadorTarefas.listaDeTarefas.Count + 1;
            Descricao = descricao;            
        }
        public void ExibirTarefa()
        {
            Formatacao.Cor($"{(Concluida ? "[X]" : "[ ]")} ID: {Id} – {Descricao}", ConsoleColor.Yellow);
        }
    }
}