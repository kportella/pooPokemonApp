using System;

namespace pooPokemonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokemon pokemon = new Pokemon("Bulbasauro", "Bulbasauro é um pokemon tipo planta...");
            pokemon.ExibirDadosPokemon(true);

        }
    }
}
