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
                    além dos que chamas as séries
                    */
                    case "1":
                        ListarConteudo();
                        break;
                    case "2":
                        InserirSerie();
                        break;
                    case "3":
                        InserirFilme();
                        break;
                    case "4":
                        //AtualizarSerie();
                        break;
                    case "5":
                        //AtualizarFilme();
                        break;
                    case "6":
                        ExcluirSerie();
                        break;
                    case "7":
                        ExcluirFilme();
                        break;
                    case "8":
                        //VisualizarSerie();
                        break;
                    case "9":
                        //VisualizarFilme();
                        break;
                    case "C":
                        Console.Clear();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();

                }
                opcaoUsuario = ObterOpcaoUsuario();
            }

            Console.WriteLine("Obrigado por utilizar nossos serviços");
            Console.ReadLine();
                    
        }

                private static void ListarConteudo()
        {
            Console.WriteLine("Listar Conteúdo");

            var listaserie = repositorioSerie.Lista();
            var listafilme = repositorioFilmes.Lista();

            if (listaserie.Count == 0)
            {
                Console.WriteLine("Nenhuma série cadastrada.");
                return;
            }
            
            if (listafilme.Count == 0)
            {
                Console.WriteLine("Nenhum filme cadastrado.");
            }

            foreach (var serie in listaserie)
            {
                    Console.WriteLine("#ID da série {0}: . {1}", serie.retornaId(), serie.retornaTitulo());
            }

            foreach (var filme in listafilme)
            {
                    Console.WriteLine("#ID {0} . {1}", filme.retornaId(), filme.retornaTitulo());
            }
        }

        private static void ExcluirSerie()
        {
            Console.Write("Digite o id da série: ");
            int indiceConteudo = int.Parse(Console.ReadLine());

            repositorioSerie.Exclui(indiceConteudo);
            
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
        
        /*
        *******************************************
            DAQUI IMPLEMENTAÇÃO PARA OS FILMES!!
        *******************************************
        */
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
            int entradaClassificacao = int.Parse(Console.ReadLine());

            Console.Write("Digite a duração em minutos deste filme: ");
            int entradaDuracao = int.Parse(Console.ReadLine());

            Console.Write("Digite a Descrição do filme ");
            string entradaDescricao = Console.ReadLine();

            Filmes novoFilme = new Filmes(id: repositorioFilmes.ProximoId(),
                                        personagem: (PersonagemFilme)entradaPersonagem,
                                        Titulo: entradaTitulo,
                                        Ano: entradaAno,
                                        classificacao: entradaClassificacao,
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
        
        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Bem vindo a minha plataforma!");
            Console.WriteLine("Aqui você poderá inserir, atualizar, visualizar e até mesmo excluir");
            Console.WriteLine("Séries e filmes do grande UCM, teste e aproveite!");
            Console.WriteLine("Informe a opcão desejada:");

            Console.WriteLine("1- Listar Conteúdo");
            Console.WriteLine("2- Inserir nova série");
            Console.WriteLine("3- Inserir novo Filme");
            Console.WriteLine("4- Atualizar Série");
            Console.WriteLine("5- Atualizar Filme");
            Console.WriteLine("6- Excluir Série");
            Console.WriteLine("7- Excluir Filme");
            Console.WriteLine("8- Visualizar Series");
            Console.WriteLine("9- Visualizar Filmes");
            Console.WriteLine("C- Limpar tela");
            Console.WriteLine("X- Sair");
            Console.WriteLine();
            
            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
