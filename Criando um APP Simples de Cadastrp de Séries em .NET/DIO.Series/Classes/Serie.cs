using System;

namespace DIO.Series
{
    public class Serie : Temp
    {
		public generoG generoG { get; set;}
        public bool spinOff {get; set;}
        
        public Serie(int id, int tipo, string titulo, string descricao, int ano, String temporada, int ndeepisodeos, bool finalizado, bool cancelado, generoG genero, bool spinoff) : base (id, tipo,titulo,descricao,ano,temporada,ndeepisodeos,finalizado,cancelado)
        {
            this.generoG = genero;
            this.spinOff = spinoff;
        }

        public bool retornaSpinOff()
		{
			return this.spinOff;
		}
    }
}