using System;

namespace DIO.Series
{
    public class Temp : Acervo
    {
		public int Temporada { get; set;}
        public int nDeEpisodios {get; set;}
        public bool Finalizado {get; set;}
        public bool Cancelado {get; set;}

        public Temp(int id, string titulo, string descricao, int ano, int temporada, int ndeepisodios, bool finalizado, bool cancelado) : base (id,titulo,descricao,ano)
        {
            this.Temporada = temporada;
            this.nDeEpisodios = ndeepisodios;
            this.Finalizado = finalizado;
            this.Cancelado = cancelado;
        }
        public override string ToString()
		{
            string retorno = "";
            retorno += this.ToString();
            retorno += "Temporada: " + this.Temporada + Environment.NewLine;
            retorno += "Número de Epi: " + this.nDeEpisodios + Environment.NewLine;
            retorno += "Finalizado: " + this.Finalizado + Environment.NewLine;
            retorno += "Cancelado: " + this.Cancelado;
			return retorno;
		}
        public int retornaTemporada()
		{
			return this.Temporada;
		}
         public int retornaNdeEpisodeos()
		{
			return this.nDeEpisodios;
		}
        public bool retornaFinalizado()
		{
			return this.Finalizado;
		}
        public bool retornaCancelado()
		{
			return this.Cancelado;
		}
    }
}