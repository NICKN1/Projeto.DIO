using System;

namespace Projeto.App
{
    public class Filmes : EntidadeBase
    {
        //Aqui adcionei atributos dos quais acho necessário para um registro de um filme no sistema
        private PersonagemFilme personagem {get; set;}
        private string Titulo {get; set;}
        private string Descricao {get; set;}
        private int Ano {get; set;}
        private int classificacao {get; set;}
        private int Duracao {get; set;}
        private bool Excluido {get; set;}

        //Métodos dos atributos dos filmes, adcionando aqueles que coloquei 
        public Filmes(int id, PersonagemFilme personagem, string Titulo, string Descricao, int Ano, int classificacao, int Duracao)
        {
            this.id = id;
            this.personagem = personagem;
            this.Titulo = Titulo;
            this.Descricao = Descricao;
            this.Ano = Ano;
            this.classificacao = classificacao;
            this.Duracao = Duracao;
            this.Excluido = false;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Personagem: " + this.personagem + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano do Lançamento: " + this.Ano + Environment.NewLine;
            retorno += "Classificação Indicativa: " + this.classificacao + Environment.NewLine;
            retorno += "Duração do Filme: " + this.Duracao + Environment.NewLine;
            retorno += "Excluído: " + this.Excluido;
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