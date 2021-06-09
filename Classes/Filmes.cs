namespace Projeto.App
{
    public class Filmes : EntidadeBase
    {
        //Aqui adcionei atributos dos quais acho necessário para um registro de um filme no sistema
        private Genero genero {get; set;}
        private string Titulo {get; set;}
        private string Descricao {get; set;}
        private int Ano {get; set;}
        private string Classificacao {get; set;}
        private float Duracao {get; set;}
        private bool Excluido {get; set;}

        //Métodos dos atributos dos filmes, adcionando aqueles que coloquei 
        public Filmes(int id, Genero genero, string Titulo, string Descricao, int Ano, int classificacao, float Duracao)
        {
            this.id = id;
            this.genero = genero;
            this.Titulo = Titulo;
            this.Descricao = Descricao;
            this.Ano = Ano;
            this.Classificacao = Classificacao;
            this.Duracao = Duracao;
            this.Excluido = false;
        }


    }
}