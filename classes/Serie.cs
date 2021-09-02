using System;
using dio.series;

namespace dio.serie
{
    public class Serie : EntidadeBase
    {
        //Atributos
        private Genero Genero {get;set;}
        private string Titulo {get;set;}
        private string Descricao {get;set;}
        private int Ano{get;set;}

        public Serie(int id,Genero genero,string titulo,string descricao,int ano)
        {
            this.id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Genero: " + this.Genero + Environment.NewLine;
            retorno += "Título: " + this.Titulo+ Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Início: " + this.Ano;
            return base.ToString();
        }

        public string retornaTitulo()
        {
            return this.Titulo;
        }

        public int retornaID()
        {
            return this.id;
        }
    }
}