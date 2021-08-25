using System;

namespace DIO.Series
{
    public class Temp : Acervo
    {
		public String Temporada { get; set;}
        public int nDeEpisodeos {get; set;}
        public bool Finalizado {get; set;}
        public bool Cancelado {get; set;}

        public Temp(int id, int tipo, string titulo, string descricao, int ano, String temporada, int ndeepisodeos, bool finalizado, bool cancelado) : base (id, tipo,titulo,descricao,ano)
        {
            this.Temporada = temporada;
            this.nDeEpisodeos = ndeepisodeos;
            this.Finalizado = finalizado;
            this.Cancelado = cancelado;
        }

        public string retornaTemporada()
		{
			return this.Temporada;
		}
         public int retornaNdeEpisodeos()
		{
			return this.nDeEpisodeos;
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