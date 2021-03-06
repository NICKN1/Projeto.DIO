using System;

namespace Projeto.App
{
    class Program
    {
        static SerieRepositorio repositorioSerie = new SerieRepositorio();
        static FilmesRepositorio repositorioFilmes = new FilmesRepositorio();
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    /*Aqui adicionei mais métodos para chamar os do repositorio dos Filmes
                    além dos que chamam as séries
                    */
                    case "1":
                        ListarSerie();
                        break;
                    case "2":
                        ListarFilme();
                        break;
                    case "3":
                        InserirSerie();
                        break;
                    case "4":
                        InserirFilme();
                        break;
                    case "5":
                        AtualizarSerie();
                        break;
                    case "6":
                        AtualizarFilme();
                        break;
                    case "7":
                        ExcluirSerie();
                        break;
                    case "8":
                        ExcluirFilme();
                        break;
                    case "9":
                        VisualizarSerie();
                        break;
                    case "10":
                        VisualizarFilme();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();

                }
                opcaoUsuario = ObterOpcaoUsuario();
            }

            Console.WriteLine("Obrigado por utilizar nossos serviços");
            Console.ReadLine();
                    
        }

                private static void ListarSerie()
        {
            Console.WriteLine("Listar Séries");

            var listaserie = repositorioSerie.Lista();

            if (listaserie.Count == 0) 
            {
                Console.WriteLine("Nenhuma série cadastrada.");
                return;
            }
            
            foreach (var serie in listaserie)
            {
                    Console.WriteLine("#ID da série {0}: . {1}", serie.retornaId(), serie.retornaTitulo());
            }
        }

        private static void AtualizarSerie()
         {
          Console.Write("Digite o id da série: ");
          int indiceSerie = int.Parse(Console.ReadLine());

           foreach (int i in Enum.GetValues(typeof(PersonagemSerie)))
          {
              Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(PersonagemSerie), i));             
          }  

          Console.Write("Digite o herói entre as opções acima: ");
            int entradaPersonagem = int.Parse(Console.ReadLine());

            Console.Write("Digite o Título da Série deste herói: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o Ano de Início da Série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a Classificação Indicação da Série: ");
            int entradaClassificacao = int.Parse(Console.ReadLine());

            Console.Write("Digite a Descrição da Série: ");
            string entradaDescricao = Console.ReadLine();

            Serie atualizaSerie = new Serie(id: indiceSerie,
                                        personagem: (PersonagemSerie)entradaPersonagem,
                                        Titulo: entradaTitulo,
                                        AnoInicio: entradaAno,
                                        Classificacao: entradaClassificacao,
                                        Descricao: entradaDescricao);
            repositorioSerie.Atualiza(indiceSerie, atualizaSerie);
          }

        private static void ExcluirSerie()
        {
            Console.Write("Digite o id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            repositorioSerie.Exclui(indiceSerie);
            
        }

           private static void InserirSerie()
        {
            Console.WriteLine("Inserir nova série");

            foreach (int i in Enum.GetValues(typeof(PersonagemSerie)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(PersonagemSerie), i));
            }
            Console.Write("Digite o herói entre as opções acima: ");
            int entradaPersonagem = int.Parse(Console.ReadLine());

            Console.Write("Digite o Título da Série deste herói: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o Ano de Início da Série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a Classificação Indicação da Série: ");
            int entradaClassificacao = int.Parse(Console.ReadLine());

            Console.Write("Digite a Descrição da Série: ");
            string entradaDescricao = Console.ReadLine();

            Serie novaSerie = new Serie(id: repositorioSerie.ProximoId(),
                                        personagem: (PersonagemSerie)entradaPersonagem,
                                        Titulo: entradaTitulo,
                                        AnoInicio: entradaAno,
                                        Classificacao: entradaClassificacao,
                                        Descricao: entradaDescricao);
            repositorioSerie.Insere(novaSerie);
        }

        private static void VisualizarSerie()
        {
            Console.Write("Digite o id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            var serie = repositorioSerie.RetornaPorId(indiceSerie);

            Console.WriteLine(serie);
        }
        
        /*
        *******************************************
            DAQUI IMPLEMENTAÇÃO PARA OS FILMES!!
        *******************************************
        */
        private static void ListarFilme()
        {
            Console.WriteLine("Listar Filmes");

            var listafilme = repositorioFilmes.Lista();

            if (listafilme.Count == 0) 
            {
                Console.WriteLine("Nenhuma série cadastrada.");
                return;
            }
            
            foreach (var serie in listafilme)
            {
                    Console.WriteLine("#ID do filme {0}: . {1}", serie.retornaId(), serie.retornaTitulo());
            }
        }

        private static void AtualizarFilme()
         {
          Console.Write("Digite o id do Filme: ");
          int indiceFilme = int.Parse(Console.ReadLine());

          foreach (int i in Enum.GetValues(typeof(PersonagemFilme)))
          {
              Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(PersonagemFilme), i));             
          }   
          Console.Write("Digite o herói entre as opções acima: ");
            int entradaPersonagem = int.Parse(Console.ReadLine());

            Console.Write("Digite o Título do Filme deste herói: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o Ano do lançamento deste filme: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a Classificação Indicação do filme: ");
            int entradaclassificacao = int.Parse(Console.ReadLine());

            Console.Write("Digite a duração em minutos deste filme: ");
            int entradaDuracao = int.Parse(Console.ReadLine());

            Console.Write("Digite a Descrição do filme: ");
            string entradaDescricao = Console.ReadLine();

            Filmes atualizaFilme = new Filmes(id: repositorioFilmes.ProximoId(),
                                        personagem: (PersonagemFilme)entradaPersonagem,
                                        Titulo: entradaTitulo,
                                        Ano: entradaAno,
                                        classificacao: entradaclassificacao,
                                        Duracao: entradaDuracao,
                                        Descricao: entradaDescricao);
            repositorioFilmes.Atualiza(indiceFilme, atualizaFilme);
          }
        
        private static void InserirFilme()
        {
            Console.WriteLine("Inserir novo filme");

            foreach (int i in Enum.GetValues(typeof(PersonagemFilme)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(PersonagemFilme), i));
            }
            Console.Write("Digite o herói entre as opções acima: ");
            int entradaPersonagem = int.Parse(Console.ReadLine());

            Console.Write("Digite o Título do Filme deste herói: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o Ano do lançamento deste filme: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a Classificação Indicação do filme: ");
            int entradaclassificacao = int.Parse(Console.ReadLine());

            Console.Write("Digite a duração em minutos deste filme: ");
            int entradaDuracao = int.Parse(Console.ReadLine());

            Console.Write("Digite a Descrição do filme: ");
            string entradaDescricao = Console.ReadLine();

          

            Filmes novoFilme = new Filmes(id: repositorioFilmes.ProximoId(),
                                        personagem: (PersonagemFilme)entradaPersonagem,                                   
                                        Titulo: entradaTitulo,
                                        Ano: entradaAno,
                                        classificacao: entradaclassificacao,
                                        Duracao: entradaDuracao,
                                        Descricao: entradaDescricao);
            repositorioFilmes.Insere(novoFilme);
        }
        
            private static void ExcluirFilme()
        {
            Console.Write("Digite o id do filme: ");
            int indiceConteudo = int.Parse(Console.ReadLine());

            repositorioFilmes.Exclui(indiceConteudo);
            
        }

        private static void VisualizarFilme()
        {
            Console.Write("Digite o id do Filme: ");
            int indiceFilme = int.Parse(Console.ReadLine());

            var filme = repositorioFilmes.RetornaPorId(indiceFilme);

            Console.WriteLine(filme);
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("*******************************************************************");
            Console.WriteLine("Bem vindo a minha plataforma!");
            Console.WriteLine("Aqui você poderá inserir, atualizar, visualizar e até mesmo excluir");
            Console.WriteLine("Séries e filmes do grande UCM, teste e aproveite!");
            Console.WriteLine("Informe a opcão desejada:");
            Console.WriteLine("*******************************************************************");
            Console.WriteLine("1- Listar Séries");
            Console.WriteLine("2- Listar Filmes");
            Console.WriteLine("3- Inserir nova série");
            Console.WriteLine("4- Inserir novo Filme");
            Console.WriteLine("5- Atualizar Série");
            Console.WriteLine("6- Atualizar Filme");
            Console.WriteLine("7- Excluir Série");
            Console.WriteLine("8- Excluir Filme");
            Console.WriteLine("9- Visualizar Series");
            Console.WriteLine("10- Visualizar Filmes");
            Console.WriteLine("C- Limpar tela");
            Console.WriteLine("X- Sair");
            Console.WriteLine();
            
            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
