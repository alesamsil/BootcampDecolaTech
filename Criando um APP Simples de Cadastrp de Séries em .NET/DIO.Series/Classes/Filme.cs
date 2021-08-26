using System;

namespace DIO.Series
{
    public class Filme : Acervo
    {
		public generoA generoG { get; set;}
        
        public Filme(int id, string titulo, string descricao, int ano, generoG genero) : base (id, titulo, descricao, ano)
        { 
            this.generoG = generoG;
        }

		public override string ToString()
		{
            string retorno = "";
            retorno += this.ToString();
            retorno += "Genero: " + this.generoG + Environment.NewLine;
			return retorno;
		}
    }
}