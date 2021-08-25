using System;

namespace DIO.Series
{
    public class Serie : Temp
    {
		private generoG Genero { get; set; }
        private bool spinOFF {get; set;}

		public Serie(generoG genero, bool spinoff)
		{
			this.Genero = genero;
            this.spinOFF = spinoff;
		}

		public bool retornaGenero()
		{
			return this.spinOFF;
		}
		
		public override string toString()
		{
            string retorno = "";
            retorno += "Genero: " + this.Genero + Environment.NewLine;
            retorno += "Spin off: " + this.spinOFF;
			return retorno;
		}

    }
}