namespace Projeto.App
{
    public class Filmes : EntidadeBase
    {
        private Genero Genero {get; set;}
        private string Titulo {get; set;}
        private string Descricao {get; set;}
        private int Ano {get; set;}
        private string Classificacao {get; set;}
        private float Duracao {get; set;}
        private bool Excluido {get; set;}
    }
}