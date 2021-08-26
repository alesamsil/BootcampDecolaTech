using System;

namespace DIO.Series
{
    class Program
    {
        static SerieRepositorio repositorioS = new SerieRepositorio();
		static FilmeRepositorio repositorioF = new FilmeRepositorio();
		static AnimeRepositorio repositorioA = new AnimeRepositorio();
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

			while (opcaoUsuario.ToUpper() != "X")
			{
				switch (opcaoUsuario)
				{
					case "1":
						ListarSeries();
						break;
					case "2":
						InserirNoCatalogo();
						break;
					case "3":
						AtualizarCatalogo();
						break;
					case "4":
						ExcluirDoCatalogo();
						break;
					case "5":
						VisualizarCatalogo();
						break;
					case "C":
						Console.Clear();
						break;

					default:
						throw new ArgumentOutOfRangeException();
				}

				opcaoUsuario = ObterOpcaoUsuario();
			}

			Console.WriteLine("Obrigado por utilizar nossos serviços.");
			Console.ReadLine();
        }

        private static void ExcluirDoCatalogo()
		{
			Console.Write("O que você deseja escluir?");
			Console.Write("1 - Anime");
			Console.Write("2 - Filme");
			Console.Write("3 - Serie");
			
			int selecao = int.Parse(Console.ReadLine());
			if (selecao == 1)
			{
				Console.Write("Digite o id do Anime: ");
				int indice = int.Parse(Console.ReadLine());
				repositorioF.Exclui(indice);
			}
			else if(selecao == 2)
			{
				Console.Write("Digite o id do Filme: ");
				int indice = int.Parse(Console.ReadLine());
				repositorioF.Exclui(indice);
			}
			else 
			{
				Console.Write("Digite o id da série: ");
				int indice = int.Parse(Console.ReadLine());
				repositorioS.Exclui(indice);
			}		
		}

        private static void VisualizarCatalogo()
		{
			Console.Write("Qual Catálogo você deseja visualizar?");
			Console.Write("1 - Anime");
			Console.Write("2 - Filme");
			Console.Write("3 - Serie");
			int selecao = int.Parse(Console.ReadLine());
			if (selecao == 1)
			{
				Console.Write("Digite o id do Anime: ");
				int indice = int.Parse(Console.ReadLine());
				var anime = repositorioA.RetornaPorId(indice);
				Console.WriteLine(anime);
			}
			else if(selecao == 2)
			{
				Console.Write("Digite o id do Filme: ");
				int indice = int.Parse(Console.ReadLine());
				var filme = repositorioF.RetornaPorId(indice);
				Console.WriteLine(filme);
			}
			else 
			{
				Console.Write("Digite o id da série: ");
				int indice = int.Parse(Console.ReadLine());
				var serie = repositorioS.RetornaPorId(indice);
				Console.WriteLine(serie);
			}			
		}

        private static void AtualizarCatalogo()
		{
			
			Console.Write("Qual Catálogo você deseja visualizar?");
			Console.Write("1 - Anime");
			Console.Write("2 - Filme");
			Console.Write("3 - Serie");
			int selecao = int.Parse(Console.ReadLine());
			if (selecao == 1)
			{
				Console.Write("Digite o id do Anime: ");
				int indiceAnime = int.Parse(Console.ReadLine());

				foreach (int i in Enum.GetValues(typeof(generoA)))
				{
					Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(generoA), i));
				}
				Console.Write("Digite o gênero entre as opções acima: ");
				int entradaGenero = int.Parse(Console.ReadLine());

				Console.Write("Digite o Título do Anime: ");
				string entradaTitulo = Console.ReadLine();

				Console.Write("Digite o Ano de Início do Anime: ");
				int entradaAno = int.Parse(Console.ReadLine());

				Console.Write("Digite a Descrição do Anime: ");
				string entradaDescricao = Console.ReadLine();

				Console.Write("Digite o número de temporadas: ");
				int entradaTemporada = int.Parse(Console.ReadLine());

				Console.Write("Digite o número de episódios: ");
				int entradaNumeroEpisodios = int.Parse(Console.ReadLine());

				Console.Write("A série foi finalizada? ");
				Console.Write("1 - Para Sim ");
				Console.Write("2 - Para Não ");
				int entradaFinalizada = int.Parse(Console.ReadLine());
				bool entradaBF;
				if(entradaFinalizada == 1){
					entradaBF = true;
				}
				else{
					entradaBF = false;
				}
				
				Console.Write("A série foi Cancelada? ");
				Console.Write("1 - Para Sim ");
				Console.Write("2 - Para Não ");
				int entradaCancelada = int.Parse(Console.ReadLine());
				bool entradaBC;
				if(entradaFinalizada == 1){
					entradaBC = true;
				}
				else{
					entradaBC = false;
				}

				Console.Write("A série possui Filer ");
				Console.Write("1 - Para Sim ");
				Console.Write("2 - Para Não ");
				int entradaSpinOff = int.Parse(Console.ReadLine());
				bool entradaBS;
				if(entradaSpinOff == 1){
					entradaBS = true;
				}
				else{
					entradaBS = false;
				}

				Anime atualizaAnime = new Anime(id: indiceAnime, titulo: entradaTitulo, descricao: entradaDescricao, ano: entradaAno, temporada:entradaTemporada, ndeepisodeos: entradaNumeroEpisodios, finalizado: entradaBF, cancelado: entradaBC, genero: (generoA)entradaGenero, filer: entradaBS);                                                                                              

				repositorioA.Atualiza(indiceAnime, atualizaAnime);

			}
			else if(selecao == 2)
			{
				Console.Write("Digite o id do Filme: ");
				int indiceFilme = int.Parse(Console.ReadLine());

				foreach (int i in Enum.GetValues(typeof(generoG)))
				{
					Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(generoG), i));
				}
				Console.Write("Digite o gênero entre as opções acima: ");
				int entradaGenero = int.Parse(Console.ReadLine());

				Console.Write("Digite o Título do filme: ");
				string entradaTitulo = Console.ReadLine();

				Console.Write("Digite o Ano de Início do filme: ");
				int entradaAno = int.Parse(Console.ReadLine());

				Console.Write("Digite a Descrição da Série: ");
				string entradaDescricao = Console.ReadLine();

				Filme atualizaFilme = new Filme(id: indiceFilme, titulo: entradaTitulo, descricao: entradaDescricao, ano: entradaAno, genero: (generoG)entradaGenero);

				repositorioF.Atualiza(indiceFilme, atualizaFilme);
			}

			else if(selecao == 3)
			{
				Console.Write("Digite o id da série: ");
				int indiceSerie = int.Parse(Console.ReadLine());

				foreach (int i in Enum.GetValues(typeof(generoG)))
				{
					Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(generoG), i));
				}
				Console.Write("Digite o gênero entre as opções acima: ");
				int entradaGenero = int.Parse(Console.ReadLine());

				Console.Write("Digite o Título da Série: ");
				string entradaTitulo = Console.ReadLine();

				Console.Write("Digite o Ano de Início da Série: ");
				int entradaAno = int.Parse(Console.ReadLine());

				Console.Write("Digite a Descrição da Série: ");
				string entradaDescricao = Console.ReadLine();

				Console.Write("Digite o número de temporadas: ");
				int entradaTemporada = int.Parse(Console.ReadLine());

				Console.Write("Digite o número de episódios: ");
				int entradaNumeroEpisodios = int.Parse(Console.ReadLine());

				Console.Write("A série foi finalizada? ");
				Console.Write("1 - Para Sim ");
				Console.Write("2 - Para Não ");
				int entradaFinalizada = int.Parse(Console.ReadLine());
				bool entradaBF;
				if(entradaFinalizada == 1){
					entradaBF = true;
				}
				else{
					entradaBF = false;
				}
				
				Console.Write("A série foi Cancelada? ");
				Console.Write("1 - Para Sim ");
				Console.Write("2 - Para Não ");
				int entradaCancelada = int.Parse(Console.ReadLine());
				bool entradaBC;
				if(entradaFinalizada == 1){
					entradaBC = true;
				}
				else{
					entradaBC = false;
				}

				Console.Write("A série é Spin Off ");
				Console.Write("1 - Para Sim ");
				Console.Write("2 - Para Não ");
				int entradaSpinOff = int.Parse(Console.ReadLine());
				bool entradaBS;
				if(entradaSpinOff == 1){
					entradaBS = true;
				}
				else{
					entradaBS = false;
				}

				Serie atualizaSerie = new Serie(id: indiceSerie, titulo: entradaTitulo, descricao: entradaDescricao, ano: entradaAno, temporada:entradaTemporada, ndeepisodeos: entradaNumeroEpisodios, finalizado: entradaBF, cancelado: entradaBC, genero: (generoG)entradaGenero, spinoff: entradaBS);

				repositorioS.Atualiza(indiceSerie, atualizaSerie);
			}
			else
			{
				Console.WriteLine("Opção inválida.");
				return;
			}			
			
		}
        private static void ListarSeries()
		{
			Console.WriteLine("Listar Filmes e Séries");

			var lista = repositorio.Lista();

			if (lista.Count == 0)
			{
				Console.WriteLine("Nenhum filme o série cadastrada.");
				return;
			}

			foreach (var serie in lista)
			{
                var excluido = serie.retornaExcluido();
                
				Console.WriteLine("#ID {0}: - {1} {2}", serie.retornaId(), serie.retornaTitulo(), (excluido ? "*Excluído*" : ""));
			}
		}

        private static void InserirNoCatalogo()
		{
			Console.WriteLine("Inserir nova série");
			foreach (int i in Enum.GetValues(typeof(generoG)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(generoG), i));
			}
			Console.Write("Digite o gênero entre as opções acima: ");
			int entradaGenero = int.Parse(Console.ReadLine());

			Console.Write("Digite o Título da Série: ");
			string entradaTitulo = Console.ReadLine();

			Console.Write("Digite o Ano de Início da Série: ");
			int entradaAno = int.Parse(Console.ReadLine());

			Console.Write("Digite a Descrição da Série: ");
			string entradaDescricao = Console.ReadLine();

			Serie novaSerie = new Serie(id: repositorio.ProximoId(), genero: (generoG)entradaGenero,	titulo: entradaTitulo, ano: entradaAno,	descricao: entradaDescricao);

			repositorio.Insere(novaSerie);
		}
        private static string ObterOpcaoUsuario()
		{
			Console.WriteLine();
			Console.WriteLine("<<< DIOFLIX >>>");
			Console.WriteLine("Informe a opção desejada:");
			Console.WriteLine("1- Listar Catálogo");
			Console.WriteLine("2- Inserir ao Catálogo");
			Console.WriteLine("3- Atualizar Catálogo");
			Console.WriteLine("4- Excluir do Catálogo");
			Console.WriteLine("5- Visualizar Catálogo");
			Console.WriteLine("C- Limpar Tela");
			Console.WriteLine("X- Sair");
			Console.WriteLine();

			string opcaoUsuario = Console.ReadLine().ToUpper();
			Console.WriteLine();
			return opcaoUsuario;
		}
    }
}
