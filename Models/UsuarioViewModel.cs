using Microsoft.Extensions.Primitives;

namespace Senai.OO.ProjetoFinal.Models {

    public class UsuarioViewModel {
        public UsuarioViewModel (int id, string nome, string email, string senha, string tipo) {
            this.Id = id;
            this.Nome = nome;
            this.Email = email;
            this.Senha = senha;
            this.Tipo = tipo;
        }
        public UsuarioViewModel (string nome, string email, string senha, string tipo) {
            this.Nome = nome;
            this.Email = email;
            this.Senha = senha;
            this.Tipo = tipo;
        }
        public UsuarioViewModel (string nome, string email, string senha) {
            this.Nome = nome;
            this.Email = email;
            this.Senha = senha;
            
        }

        public int Id { get; set; }

        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Tipo { get; set; }

    }
}