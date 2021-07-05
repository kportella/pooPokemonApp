using System;

namespace pooPokemonApp
{
    public class Pokemon
    {
        public Pokemon()
        {
            this.Nome = "";
            this.Descricao = "";
        }
        private string nome;
        public string Nome
        {
            get { return nome; }
            set
            {
                string texto = value.ToUpper();
                nome = texto;
            }
        }

        private string descricao;
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value.ToUpper(); }
        }

        public void ExibirDadosPokemon()
        {
            Console.WriteLine("Nome do Pokémon: " + this.Nome);
            Console.WriteLine("Descrição do Pokémon: " + this.Descricao);
        }

    }
}
