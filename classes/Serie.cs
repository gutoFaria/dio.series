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
}