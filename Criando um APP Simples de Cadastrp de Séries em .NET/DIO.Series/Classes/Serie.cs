using System;

namespace DIO.Series
{
    public class Serie : Temp
    {
		public generoG generoG { get; set;}
        public bool spinOff {get; set;}
        
        public Serie(int id, string titulo, string descricao, int ano, int temporada, int ndeepisodeos, bool finalizado, bool cancelado, generoG genero, bool spinoff) : base (id, titulo,descricao,ano,temporada,ndeepisodeos,finalizado,cancelado)
        {
            this.generoG = genero;
            this.spinOff = spinoff;
        }

		public override string ToString()
		{
            string retorno = "";
            retorno += this.ToString();
            retorno += "Genero: " + this.generoG + Environment.NewLine;
            retorno += "Spin Off: " + this.spinOff + Environment.NewLine;
			return retorno;
		}

        public bool retornaSpinOff()
		{
			return this.spinOff;
		}
    }
}