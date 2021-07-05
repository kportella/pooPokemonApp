using System.Collections.Generic;

namespace pooPokemonApp
{
    public class Pokedex
    {
        public Pokedex()
        {
            this.InicializaLista();
        }
        private List<Pokemon> pokemons;

        public List<Pokemon> Pokemons
        {
            get { return pokemons; }
        }

        private void InicializaLista()
        {
            // Instanciar a Lista
            this.pokemons = new List<Pokemon>();
            Pokemon pokemon = new Pokemon("Bulbasauro", "pokemon tipo planta");
            this.pokemons.Add(pokemon);
            pokemon = new Pokemon("Mew", "lendario psiquico");
            this.pokemons.Add(pokemon);
            pokemon = new Pokemon("Mewtwo", "lendario psiquico");
            this.pokemons.Add(pokemon);
            pokemon = new Pokemon("Giratina", "lendario fantasma");
            this.pokemons.Add(pokemon);
            pokemon = new Pokemon("Flygon", "pokemon dragao");
            this.pokemons.Add(pokemon);
            pokemon = new Pokemon("Metagross", "pokemon de metal");
            this.pokemons.Add(pokemon);
            pokemon = new Pokemon("Muk", "pokemon toxico");
            this.pokemons.Add(pokemon);
            pokemon = new Pokemon("Lucario", "lutador lendario");
            this.pokemons.Add(pokemon);
            pokemon = new Pokemon("Paras", "pokemon inseto");
            this.pokemons.Add(pokemon);
            pokemon = new Pokemon("Kyogre", "lendario de agua");
            this.pokemons.Add(pokemon);
            pokemon = new Pokemon("Mudkip", "lendario de agua");
            this.pokemons.Add(pokemon);
        }
    }
}
