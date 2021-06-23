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
                        AtualizarSerie();
                        break;
                    case "5":
                        AtualizarFilme();
                        break;
                    case "6":
                        ExcluirConteudo();
                        break;
                    case "7":
                        VisualizarSerie();
                        break;
                    case "8":
                        VisualizarFilme();
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

        private static void ExcluirConteudo()
        {
            Console.Write("Digite o id da série: ");
            int indiceConteudo = int.Parse(Console.ReadLine());

            repositorioSerie.Exclui(indiceConteudo);
            repositorioFilmes.Exclui(indiceConteudo);
        }

           private static void InserirSerie()
        {
            Console.WriteLine("Inserir nova série");

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.Write("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o Título da Série: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o Ano de Início da Série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a Descrição da Série: ");
            string entradaDescricao = Console.ReadLine();

            Serie novaSerie = new Serie(id: repositorio.ProximoId(),
                                        genero: (Genero)entradaGenero,
                                        Titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao);
            repositorio.Insere(novaSerie);
        }
            
        
        
        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("DIO Séries a seu dispor!!!");
            Console.WriteLine("Informe a opcão desejada:");

            Console.WriteLine("1- Listar Conteúdo");
            Console.WriteLine("2- Inserir nova série");
            Console.WriteLine("3- Inserir novo Filme");
            Console.WriteLine("4- Atualizar Série");
            Console.WriteLine("5- Atualizar Filme");
            Console.WriteLine("6- Excluir conteúdo");
            Console.WriteLine("7- Visualizar Series");
            Console.WriteLine("8- Visualizar Filmes");
            Console.WriteLine("C- Limpar tela");
            Console.WriteLine("X- Sair");
            Console.WriteLine();
            
            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
