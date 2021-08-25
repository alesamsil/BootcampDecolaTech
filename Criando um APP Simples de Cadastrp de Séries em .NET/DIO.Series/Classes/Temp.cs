using System;

namespace DIO.Series
{
    public class Temp : Acervo
    {
		private String Temporada { get; set;}
        private int nDeEpisodeos {get; set;}
        private bool Finalizado {get; set;}
        private bool Cancelado {get; set;}

        public Temp(String temporada, int ndeepisodeos, bool finalizado, bool cancelado)
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