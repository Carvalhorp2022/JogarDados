using System;

namespace JogoDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao Jogo de Dados!");

            // Solicitação dos nomes dos jogadores
            Console.Write("Digite o nome do primeiro jogador: ");
            string jogador1 = Console.ReadLine();

            Console.Write("Digite o nome do segundo jogador: ");
            string jogador2 = Console.ReadLine();

            // Validação dos nomes dos jogadores
            while (jogador1 == jogador2)
            {
                Console.WriteLine("Os nomes dos jogadores não podem ser iguais!");
                Console.Write("Digite o nome do segundo jogador novamente: ");
                jogador2 = Console.ReadLine();
            }

            // Seleção da quantidade de rodadas
            Console.WriteLine("Selecione a quantidade de rodadas (entre 1 e 3): ");
            int quantidadeRodadas = int.Parse(Console.ReadLine());

            // Validação da quantidade de rodadas
            while (quantidadeRodadas < 1 || quantidadeRodadas > 3)
            {
                Console.WriteLine("A quantidade de rodadas deve estar entre 1 e 3!");
                Console.WriteLine("Selecione a quantidade de rodadas novamente: ");
                quantidadeRodadas = int.Parse(Console.ReadLine());
            }

            int pontosJogador1 = 0;
            int pontosJogador2 = 0;

            // Loop para as rodadas do jogo
            for (int rodada = 1; rodada <= quantidadeRodadas; rodada++)
            {
                Console.WriteLine($"\nRodada {rodada}:");

                // Jogo de dados para o jogador 1
                int dadoJogador1 = JogarDado();
                Console.WriteLine($"{jogador1} tirou o número {dadoJogador1}");

                // Jogo de dados para o jogador 2
                int dadoJogador2 = JogarDado();
                Console.WriteLine($"{jogador2} tirou o número {dadoJogador2}");

                // Verificação do vencedor da rodada
                if (dadoJogador1 > dadoJogador2)
                {
                    pontosJogador1++;
                    Console.WriteLine($"{jogador1} venceu a rodada {rodada}");
                }
                else if (dadoJogador2 > dadoJogador1)
                {
                    pontosJogador2++;
                    Console.WriteLine($"{jogador2} venceu a rodada {rodada}");
                }
                else
                {
                    Console.WriteLine("Empate");
                }

                // Placar atualizado
                Console.WriteLine($"Pontos do jogador {jogador1}: {pontosJogador1}");
                Console.WriteLine($"Pontos do jogador {jogador2}: {pontosJogador2}");
                
            }

            // Verificação do vencedor do jogo
            Console.WriteLine("\nFim do Jogo!");

            if (pontosJogador1 > pontosJogador2)
            {
                Console.WriteLine($"{jogador1} venceu o jogo!");
            }
            else if (pontosJogador2 > pontosJogador1)
            {
                Console.WriteLine($"{jogador2} venceu o jogo!");
            }
            else
            {
                Console.WriteLine("O jogo terminou em empate!");

                // Continua jogando até haver um vencedor
                while (pontosJogador1 == pontosJogador2)
                {
                    Console.WriteLine("\nRodada Extra:");

                    // Jogo de dados para o jogador 1
                    int dadoJogador1 = JogarDado();
                    Console.WriteLine($"{jogador1} tirou o número {dadoJogador1}");

                    // Jogo de dados para o jogador 2
                    int dadoJogador2 = JogarDado();
                    Console.WriteLine($"{jogador2} tirou o número {dadoJogador2}");

                    // Verificação do vencedor da rodada extra
                    if (dadoJogador1 > dadoJogador2)
                    {
                        pontosJogador1++;
                        Console.WriteLine($"{jogador1} venceu a rodada extra");
                    }
                    else if (dadoJogador2 > dadoJogador1)
                    {
                        pontosJogador2++;
                        Console.WriteLine($"{jogador2} venceu a rodada extra");
                    }
                    else
                    {
                        Console.WriteLine("Empate");
                    }

                    // Placar atualizado da rodada extra
                    Console.WriteLine($"Pontos do jogador {jogador1}: {pontosJogador1}");
                    Console.WriteLine($"Pontos do jogador {jogador2}: {pontosJogador2}");
                   
                }

                // Verificação do vencedor da rodada extra
                if (pontosJogador1 > pontosJogador2)
                {
                    Console.WriteLine($"{jogador1} venceu o jogo!");
                }
                else
                {
                    Console.WriteLine($"{jogador2} venceu o jogo!");
                    Console.ReadKey();
                }
            }
        }

        // Método para jogar o dado
        static int JogarDado()
        {
            Random random = new Random();
            return random.Next(1, 7);
            Console.ReadKey();
            
        }
    }
}