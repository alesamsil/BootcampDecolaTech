using System;

namespace DIO.Series
{
    public class Acervo
    {
         public int Id { get; set;}
         public int Tipo {get; set;}
         public string Titulo { get; set;}
         public string Descricao { get; set;}
         public int Ano { get; set;}
         public bool Excluido {get; set;}

         public Acervo(int id, int tipo, string titulo, string descricao, int ano)
         {
            this.Id = id;
            this.Tipo = tipo;
			this.Titulo = titulo;
			this.Descricao = descricao;
			this.Ano = ano;
            this.Excluido = false;
         }

        public override string ToString()
		{
            string retorno = "";
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Lançamento: " + this.Ano + Environment.NewLine;
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
        public int retornaTipo()
		{
			return this.Tipo;
		}
        public void Excluir() 
        {    
            this.Excluido = true;
        }
    }
}