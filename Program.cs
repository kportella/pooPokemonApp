using System;

namespace pooPokemonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokedex pokedex = new Pokedex();
            Pokemon pokemon = pokedex.Pokemons[1];
            pokemon.ExibirDadosPokemon();


        }
    }
}
