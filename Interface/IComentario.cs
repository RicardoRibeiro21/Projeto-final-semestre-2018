using System.Collections.Generic;
using Senai.OO.ProjetoFinal.Models;

namespace Senai.OO.ProjetoFinal.Interface
{
    public interface IComentario
    {
         ComentarioModel Cadastrar(ComentarioModel comentario);
         List<ComentarioModel> Listar ();
         void Salvar();
         void Aprovar(int id);
         ComentarioModel Procurar(int id);
        }
}