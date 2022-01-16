using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIO.Series
{
    public class Serie : EntidadeBase
    {
        //Atrinbutos

        private Generd Generd { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }

        //Metodos

        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
        }

        public override string ToString()
        {
            // Enviroment.NewLine https://docs.microsoft.com/en-us/dotnet/api/system.environment.newline?view-netcore-3.1
            string retorno = "";
            retorno += "Genero: " + this.Genero + Enviroment.NewLine;
            retorno += "Tilulo: " + this.Tilulo + Enviroment.NewLine;
            retorno += "Descrição: " + this.Descricao + Enviroment.NewLine;
            retorno += "Ano de Inicio: " + this.Ano;
            return retorno;
        }
    }
}