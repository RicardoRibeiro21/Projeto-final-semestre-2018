using System;
using Microsoft.Extensions.Primitives;

namespace Senai.OO.ProjetoFinal.Models
{
    public class ComentarioModel
    {
        public DateTime DataCriacao { get; set; }
        public string Texto { get; set; }
        public string Usuario { get; set; }
        public bool Aprovacao { get; set; }
        public int Id { get; set; }
    public ComentarioModel (string texto, string usuario, int id, bool aprovacao, DateTime dataCriacao){
        this.Id = id;
        this.Aprovacao = aprovacao;
        this.DataCriacao = dataCriacao;
        this.Texto = texto;
        this.Usuario = usuario;
    }

        public ComentarioModel(string texto, int id)
        {
            this.Texto = texto;
            this.Id = id;
        }
    }
}