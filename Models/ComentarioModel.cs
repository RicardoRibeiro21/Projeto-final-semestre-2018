using System;

namespace Senai.OO.ProjetoFinal.Models
{
    public class ComentarioModel
    {
        public DateTime dataCriacao { get; set; }
        public string texto { get; set; }
        public string usuario { get; set; }
        public bool aprovacao { get; set; }
        public int Id { get; set; }
    }
}