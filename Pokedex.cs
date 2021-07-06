using System.Collections.Generic;

namespace pooPokemonApp
{
    public class Pokedex
    {
        public Pokedex()
        {
            this.InicializaLista();
        }
        private List<PokemonPlus> pokemons;

        public List<PokemonPlus> Pokemons
        {
            get { return pokemons; }
        }

        private void InicializaLista()
        {
            // Instanciar a Lista
            this.pokemons = new List<PokemonPlus>();
            PokemonPlus pokemon = new PokemonPlus("Bulbasauro", "pokemon tipo planta", 100);
            this.pokemons.Add(pokemon);
            pokemon = new PokemonPlus("Mew", "lendario psiquico", 90);
            this.pokemons.Add(pokemon);
            pokemon = new PokemonPlus("Mewtwo", "lendario psiquico", 70);
            this.pokemons.Add(pokemon);
            pokemon = new PokemonPlus("Giratina", "lendario fantasma", 95);
            this.pokemons.Add(pokemon);
            pokemon = new PokemonPlus("Flygon", "pokemon dragao", 55);
            this.pokemons.Add(pokemon);
            pokemon = new PokemonPlus("Metagross", "pokemon de metal", 11);
            this.pokemons.Add(pokemon);
            pokemon = new PokemonPlus("Muk", "pokemon toxico", 50);
            this.pokemons.Add(pokemon);
            pokemon = new PokemonPlus("Lucario", "lutador lendario", 70);
            this.pokemons.Add(pokemon);
            pokemon = new PokemonPlus("Paras", "pokemon inseto", 65);
            this.pokemons.Add(pokemon);
            pokemon = new PokemonPlus("Kyogre", "lendario de agua", 35);
            this.pokemons.Add(pokemon);
            pokemon = new PokemonPlus("Mudkip", "lendario de agua", 64);
            this.pokemons.Add(pokemon);
        }

        public void ListarPokemons()
        {
            for (int i = 0; i < this.Pokemons.Count; i++)
            {
                this.Pokemons[i].ExibirDadosPokemon();
            }
        }
    }
}
