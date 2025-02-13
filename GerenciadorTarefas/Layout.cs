namespace Layout
{
    class Formatacao
    {
        public static void Cor(string mensagem, ConsoleColor cor)
        {
            Console.ForegroundColor = cor;
            Console.WriteLine(mensagem);
            Console.ResetColor();
        }
        public static void ImprimirCabecalho()
        {
            Cor("╔════════════════════════╗", ConsoleColor.Cyan);
            Cor("║ GERENCIADOR DE TAREFAS ║", ConsoleColor.Cyan);
            Cor("╚════════════════════════╝", ConsoleColor.Cyan);
            Console.WriteLine();
        }
    }
}