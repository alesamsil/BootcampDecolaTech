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
						ListarCatalogo();
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
			Console.Write("O que você deseja excluir?");
			Console.Write("1 - Anime ");
			Console.Write("2 - Filme ");
			Console.Write("3 - Serie ");
			
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
			else if (selecao == 3)
			{
				Console.Write("Digite o id da série: ");
				int indice = int.Parse(Console.ReadLine());
				repositorioS.Exclui(indice);
			}
			else
			{
				Console.WriteLine("Opção inválida.");
				return;
			}		
		}

        private static void VisualizarCatalogo()
		{
			Console.Write("Qual Catálogo você deseja visualizar?");
			Console.Write("1 - Anime ");
			Console.Write("2 - Filme ");
			Console.Write("3 - Serie ");
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
			else if(selecao == 3)
			{
				Console.Write("Digite o id da série: ");
				int indice = int.Parse(Console.ReadLine());
				var serie = repositorioS.RetornaPorId(indice);
				Console.WriteLine(serie);
			}
			else
			{
				Console.WriteLine("Opção inválida.");
				return;
			}			
		}

        private static void AtualizarCatalogo()
		{
			
			Console.Write("Qual Catálogo você deseja atualizar? \n");
			Console.Write("1 - Anime \n");
			Console.Write("2 - Filme \n");
			Console.Write("3 - Serie \n");
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

				Console.Write("A série foi finalizada? \n");
				Console.Write("1 - Para Sim \n");
				Console.Write("2 - Para Não \n");
				int entradaFinalizada = int.Parse(Console.ReadLine());
				bool entradaBF;
				if(entradaFinalizada == 1){
					entradaBF = true;
				}
				else{
					entradaBF = false;
				}
				
				Console.Write("A série foi Cancelada? \n");
				Console.Write("1 - Para Sim \n");
				Console.Write("2 - Para Não \n");
				int entradaCancelada = int.Parse(Console.ReadLine());
				bool entradaBC;
				if(entradaFinalizada == 1){
					entradaBC = true;
				}
				else{
					entradaBC = false;
				}

				Console.Write("A série possui Filer \n");
				Console.Write("1 - Para Sim \n");
				Console.Write("2 - Para Não \n");
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

				Console.Write("A série foi finalizada? \n");
				Console.Write("1 - Para Sim \n");
				Console.Write("2 - Para Não \n");
				int entradaFinalizada = int.Parse(Console.ReadLine());
				bool entradaBF;
				if(entradaFinalizada == 1){
					entradaBF = true;
				}
				else{
					entradaBF = false;
				}
				
				Console.Write("A série foi Cancelada? \n");
				Console.Write("1 - Para Sim \n");
				Console.Write("2 - Para Não \n");
				int entradaCancelada = int.Parse(Console.ReadLine());
				bool entradaBC;
				if(entradaFinalizada == 1){
					entradaBC = true;
				}
				else{
					entradaBC = false;
				}

				Console.Write("A série é Spin Off \n");
				Console.Write("1 - Para Sim \n");
				Console.Write("2 - Para Não \n");
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

        private static void InserirNoCatalogo()
		{
			Console.Write("Qual Catálogo você deseja visualizar?");
			Console.Write("1 - Anime \n");
			Console.Write("2 - Filme \n");
			Console.Write("3 - Serie \n");
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

				Console.Write("A série foi finalizada? \n");
				Console.Write("1 - Para Sim \n");
				Console.Write("2 - Para Não \n");
				int entradaFinalizada = int.Parse(Console.ReadLine());
				bool entradaBF;
				if(entradaFinalizada == 1){
					entradaBF = true;
				}
				else{
					entradaBF = false;
				}
				
				Console.Write("A série foi Cancelada? \n");
				Console.Write("1 - Para Sim \n");
				Console.Write("2 - Para Não \n");
				int entradaCancelada = int.Parse(Console.ReadLine());
				bool entradaBC;
				if(entradaFinalizada == 1){
					entradaBC = true;
				}
				else{
					entradaBC = false;
				}

				Console.Write("A série possui Filer \n");
				Console.Write("1 - Para Sim \n");
				Console.Write("2 - Para Não \n");
				int entradaSpinOff = int.Parse(Console.ReadLine());
				bool entradaBS;
				if(entradaSpinOff == 1){
					entradaBS = true;
				}
				else{
					entradaBS = false;
				}

				Anime novoAnime = new Anime(id: indiceAnime, titulo: entradaTitulo, descricao: entradaDescricao, ano: entradaAno, temporada:entradaTemporada, ndeepisodeos: entradaNumeroEpisodios, finalizado: entradaBF, cancelado: entradaBC, genero: (generoA)entradaGenero, filer: entradaBS);                                                                                              

				repositorioA.Insere(novoAnime);	
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

				Filme novoFilme = new Filme(id: repositorioS.ProximoId(), titulo: entradaTitulo, descricao: entradaDescricao, ano: entradaAno, genero: (generoG)entradaGenero);

				repositorioF.Insere(novoFilme);	
			}
			else if (selecao == 3)
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

				Console.Write("A série foi finalizada? \n");
				Console.Write("1 - Para Sim \n");
				Console.Write("2 - Para Não \n");
				int entradaFinalizada = int.Parse(Console.ReadLine());
				bool entradaBF;
				if(entradaFinalizada == 1){
					entradaBF = true;
				}
				else{
					entradaBF = false;
				}
				
				Console.Write("A série foi Cancelada? \n");
				Console.Write("1 - Para Sim \n");
				Console.Write("2 - Para Não \n");
				int entradaCancelada = int.Parse(Console.ReadLine());
				bool entradaBC;
				if(entradaFinalizada == 1){
					entradaBC = true;
				}
				else{
					entradaBC = false;
				}

				Console.Write("A série é Spin Off \n");
				Console.Write("1 - Para Sim \n");
				Console.Write("2 - Para Não \n");
				int entradaSpinOff = int.Parse(Console.ReadLine());
				bool entradaBS;
				if(entradaSpinOff == 1){
					entradaBS = true;
				}
				else{
					entradaBS = false;
				}

				Serie novaSerie = new Serie(id: repositorioS.ProximoId(), titulo: entradaTitulo, descricao: entradaDescricao, ano: entradaAno, temporada:entradaTemporada, ndeepisodeos: entradaNumeroEpisodios, finalizado: entradaBF, cancelado: entradaBC, genero: (generoG)entradaGenero, spinoff: entradaBS);

				repositorioS.Insere(novaSerie);	
			}
			else
			{
				Console.WriteLine("Opção inválida.");
				return;
			}
		}
        private static void ListarCatalogo()
		{
			Console.Write("Qual catálogo você deseja listar? \n");
			Console.Write("1 - Anime \n");
			Console.Write("2 - Filme \n");
			Console.Write("3 - Serie \n");
			
			int selecao = int.Parse(Console.ReadLine());
			if (selecao == 1)
			{
				Console.WriteLine("Listar Animes ");

				var lista = repositorioA.Lista();

				if (lista.Count == 0)
				{
					Console.WriteLine("Nenhum Filme encontrado. ");
					return;
				}

				foreach (var anime in lista)
				{
					var excluido = anime.retornaExcluido();
					
					Console.WriteLine("#ID {0}: - {1} {2}", anime.retornaId(), anime.retornaTitulo(), (excluido ? "*Excluído*" : ""));
				}
			}
			else if(selecao == 2)
			{
				Console.WriteLine("Listar Filmes ");

				var lista = repositorioF.Lista();

				if (lista.Count == 0)
				{
					Console.WriteLine("Nenhum Filme encontrado. ");
					return;
				}

				foreach (var filme in lista)
				{
					var excluido = filme.retornaExcluido();
					
					Console.WriteLine("#ID {0}: - {1} {2}", filme.retornaId(), filme.retornaTitulo(), (excluido ? "*Excluído*" : ""));
				}
			}
			else if (selecao == 3)
			{
				Console.WriteLine("Listar Séries ");

				var lista = repositorioS.Lista();

				if (lista.Count == 0)
				{
					Console.WriteLine("Nenhuma série cadastrada. ");
					return;
				}

				foreach (var serie in lista)
				{
					var excluido = serie.retornaExcluido();
					
					Console.WriteLine("#ID {0}: - {1} {2}", serie.retornaId(), serie.retornaTitulo(), (excluido ? "*Excluído*" : ""));
				}
			}
			else
			{
				Console.WriteLine("Opção inválida. ");
				return;
			}		
			
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
