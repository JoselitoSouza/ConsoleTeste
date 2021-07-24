using System;

namespace ConsoleCore
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogador = new JogoFODA(new Jogador1(), new Jogador2());
            jogador.IniciarJogo();
        }
    }
}
