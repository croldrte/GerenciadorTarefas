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
            Console.WriteLine(new string(' ', (Console.WindowWidth - 26) / 2) + "╔════════════════════════╗");
            Console.WriteLine(new string(' ', (Console.WindowWidth - 26) / 2) + "║ GERENCIADOR DE TAREFAS ║");
            Console.WriteLine(new string(' ', (Console.WindowWidth - 26) / 2) + "╚════════════════════════╝");
            Console.WriteLine();
        }
    }
}