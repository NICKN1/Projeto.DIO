using System;

namespace Projeto.App
{
    public class Serie : EntidadeBase
    {
        //Estes são os atributos da classe Serie, no qual adicionei mais alguns de minha preferência
        private Genero genero {get; set;}
        private string Titulo {get; set;}
        private string Descricao {get; set;}
        private int AnoInicio {get; set;}
        private int AnoEncerramento {get; set;}
        private int Classificacao {get; set;}
        private bool Excluido {get; set;}

            //Estes são os métodos, adcionando os atributos abordados acima
        public Serie(int id, Genero genero, string Titulo, string Descricao, int AnoInicio, int AnoEncerramento, int Classificacao)
        {
            this.id = id;
            this.genero = genero;
            this.Titulo = Titulo;
            this.Descricao = Descricao;
            this.AnoInicio = AnoInicio;
            this.AnoEncerramento = AnoEncerramento;
            this.Classificacao = Classificacao;
            this.Excluido = false;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + this.genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano do Inicio: " + this.AnoInicio + Environment.NewLine;
            retorno += "Ano do Encerramento: " + this.AnoEncerramento + Environment.NewLine;
            retorno += "Classificação Indicativa: " + this.Classificacao + Environment.NewLine;
            return retorno;
        }

        public string retornaTitulo()
        {
            return this.Titulo;
        }

        public int retornaId()
        {
            return this.id;
        }

        public void Excluir()
        {
            this.Excluido = true;
        }
        

        
    }
}