namespace Projeto.App
{
    public class Serie : EntidadeBase
    {
        //Estes são os atributos da classe Serie, no qual adicionei mais alguns de minha preferência
        private Genero Genero {get; set;}
        private string Titulo {get; set;}
        private string Descricao {get; set;}
        private int AnoInicio {get; set;}
        private int AnoEncerramento {get; set;}
        private string Classificacao {get; set;}
        private bool Excluido {get; set;}

    }
}