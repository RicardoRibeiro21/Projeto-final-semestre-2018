using System.Collections.Generic;
using Senai.OO.ProjetoFinal.Models;
using Senai.OO.ProjetoFinal.Repositorio;
namespace Senai.OO.ProjetoFinal.Interface
{
   
    
    public interface IUsuario {
        /// <summary>
        /// Lista todos os usuários
        /// </summary>
        /// <returns>Retorna um List<UsuarioViewModel></returns>
        List<UsuarioViewModel> Listar ();

        /// <summary>
        /// Cadastrar um novo usuário
        /// </summary>
        /// <param name="usuario">UsuarioModel</param>
        /// <returns>Retorna um usuário</returns>
        UsuarioViewModel Cadastrar (UsuarioViewModel usuario);

        /// <summary>
        /// Edita um usuario
        /// </summary>
        /// <param name="usuario">UsuarioModel</param>
        /// <returns>Retorna um UsuarioModel editado</returns>
        UsuarioViewModel Editar (UsuarioViewModel usuario);

        /// <summary>
        /// Exclui um usuário por meio do seu Id
        /// </summary>
        /// <param name="id">id do usuário</param>
        void Excluir (int id);

        /// <summary>
        /// Efetua o login do usuário
        /// </summary>
        /// <param name="email">Email do usuário</param>
        /// <param name="senha">Senha do usuário</param>
        /// <returns></returns>
        UsuarioViewModel FazerLogin (string email, string senha);

        UsuarioViewModel BuscarPorId (int id);
    }
}
    