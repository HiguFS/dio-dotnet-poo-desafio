using System;

namespace DIO.Series
{
    public class Livro : EntidadeBase
    
    {
        // Atributos
		private Genero Genero { get; set; }
		private string Titulo { get; set; }
		private string Descricao { get; set; }
		private int Edicao { get; set; }
		private string Autor { get; set; }
        private bool Excluido {get; set;}
        

        // Métodos
		public Livro (int id, Genero genero, string titulo, string descricao, int edicao, string autor)
		{
			this.Id = id;
			this.Genero = genero;
			this.Titulo = titulo;
			this.Descricao = descricao;
			this.Edicao = edicao;
			this.Autor = autor;
            this.Excluido = false;
            
		}

        public override string ToString()
		{
			// Environment.NewLine https://docs.microsoft.com/en-us/dotnet/api/system.environment.newline?view=netcore-3.1
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Edição: " + this.Edicao + Environment.NewLine;
			retorno += "Autor: " + this.Autor   + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido;
            
			return retorno;
		}

        public string retornaTitulo()
		{
			return this.Titulo;
		}

		public int retornaId()
		{
			return this.Id;
		}
        public bool retornaExcluido()
		{
			return this.Excluido;
		}
        public void Excluir() {
            this.Excluido = true;
        }
    }
}