using System;
using System.Threading;

class Program
{
    // Enumeração para as cores do semáforo
    enum CorSemaforo
    {
        Verde,
        Amarelo,
        Vermelho
    }

    static void Main(string[] args)
    {
        // Define a duração de cada cor em milissegundos
        int duracaoVerde = 5000;  // 5 segundos
        int duracaoAmarelo = 2000; // 2 segundos
        int duracaoVermelho = 5000; // 5 segundos

        while (true)        
        {
            // Exibe o estado verde
            MudarCorSemaforo(CorSemaforo.Verde);
            Thread.Sleep(duracaoVerde);

            // Exibe o estado amarelo
            MudarCorSemaforo(CorSemaforo.Amarelo);
            Thread.Sleep(duracaoAmarelo);

            // Exibe o estado vermelho
            MudarCorSemaforo(CorSemaforo.Vermelho);
            Thread.Sleep(duracaoVermelho);
        }
    }

    // Método para mudar a cor do semáforo
    static void MudarCorSemaforo(CorSemaforo cor)
    {
        switch (cor)
        {
            case CorSemaforo.Verde:
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Sinal Verde - Pode seguir!");
                break;
            case CorSemaforo.Amarelo:
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Sinal Amarelo - Atenção!");
                break;
            case CorSemaforo.Vermelho:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sinal Vermelho - Pare!");
                break;
        }
        // Reseta a cor do console
        Console.ResetColor();
    }
}
