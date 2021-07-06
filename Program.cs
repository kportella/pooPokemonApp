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
                if (resp == 1)
                {
                    pokedex.ListarPokemons();
                }
                Console.ReadKey();
                Console.Clear();
            }

        }

        static int Menu()
        {
            Console.WriteLine("Pokédex----Agenda Pokémon");
            Console.WriteLine("1 - Listar todos os Pokémons");
            Console.Write("O que deseja fazer: ");
            int resp = Convert.ToInt32(Console.ReadLine());
            return resp;
        }
    }
}
