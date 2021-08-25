using System;

namespace DIO.Series
{
    public class Anime : Temp
    {
		public generoA generoA { get; set;}
        public bool filer {get; set;}
        
        public Anime(int id, int tipo, string titulo, string descricao, int ano, String temporada, int ndeepisodeos, bool finalizado, bool cancelado, generoA genero, bool spinoff) : base (id, tipo,titulo,descricao,ano,temporada,ndeepisodeos,finalizado,cancelado)
        {
            this.generoA = generoA;
            this.filer = filer;
        }

        public override string ToString()
		{
            string retorno = "";
            retorno += this.ToString();
            retorno += "Genero: " + this.generoA + Environment.NewLine;
            retorno += "Spin Off: " + this.filer + Environment.NewLine;
			return retorno;
		}

        public bool retornaSpinOff()
		{
			return this.filer;
		}
    }
}