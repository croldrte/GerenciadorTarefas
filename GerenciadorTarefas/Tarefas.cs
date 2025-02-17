using Layout;
using GerenciarTarefa;

namespace Tarefas
{
    public class Tarefa
    {
        private static int proximoId = 1;
        public bool Concluida { get; set; }
        public int Id { get; set; }
        public string Descricao { get; set; }
        public Tarefa(string descricao)
        {
            Concluida = false;
            Id = proximoId++;
            Descricao = descricao;            
        }
        public void ExibirTarefa()
        {
            Formatacao.Cor($"{(Concluida ? "[X]" : "[ ]")} ID: {Id} – {Descricao}", ConsoleColor.Yellow);
        }
    }
}