using System;

namespace pooPokemonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokedex pokedex = new Pokedex();
            int resp = 100;
            while (resp != 0)
            {
                resp = Menu();
                Console.Clear();
                if (resp == 1)
                {
                    pokedex.ListarPokemons();
                }
                if (resp == 2)
                {
                    pokedex.ListarPokemons();
                    Console.Write("Digite o código do pokémon: ");
                    int codigo = Convert.ToInt32(Console.ReadLine());
                    PokemonPlus pPlayer = pokedex.Pokemons[codigo];
                    Random random = new Random();
                    codigo = random.Next(0, pokedex.Pokemons.Count);
                    PokemonPlus pPC = pokedex.Pokemons[codigo];

                    Console.WriteLine("Dados dos pokémons que irão lutar");
                    Console.WriteLine("Dados do seu pokémon");
                    pPlayer.ExibirDadosPokemonPlus();
                    Console.WriteLine("Dados do outro pokémon");
                    pPC.ExibirDadosPokemonPlus();

                    if (pPlayer.Poder >= pPC.Poder)
                    {
                        Console.WriteLine("Parabens!!! Você ganhou");
                    }
                    else
                    {
                        Console.WriteLine("Que pena!!! Você perdeu");
                    }

                }
                Console.ReadKey();
                Console.Clear();
            }

        }

        static int Menu()
        {
            Console.WriteLine("Pokémon ---- Jogo de batalha");
            Console.WriteLine("0 - Sair do jogo");
            Console.WriteLine("1 - Listar todos os Pokémons da pokédex");
            Console.WriteLine("2 - Batalhar");
            Console.Write("O que deseja fazer: ");
            int resp = Convert.ToInt32(Console.ReadLine());
            return resp;
        }
    }
}
