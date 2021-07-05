using System;

namespace pooPokemonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokemon pokemon = new Pokemon();
            pokemon.Nome = "Bulbasauro";
            pokemon.Descricao = "Bulbasauro é um pokemo tipo planta...";
            pokemon.ExibirDadosPokemon();

        }
    }
}
