using System.Collections.Generic;
using Senai.OO.ProjetoFinal.Models;

namespace Senai.OO.ProjetoFinal.Repositorio
{
    public class ComentarioRepositorio
    {
         public List<ComentarioModel> Listar () {
            List<ComentarioModel> lsComentarios = new List<ComentarioModel> ();

            string[] linhas = System.IO.File.ReadAllLines ("comentarios.csv");

            ComentarioModel comentario;

            foreach (var item in linhas) {

                //Verifica se a linha é vazia
                if (string.IsNullOrEmpty (item)) {
                    //Retorna para o foreach
                    continue;
                }

                string[] linha = item.Split (';');

                comentario = new ComentarioModel (id: int.Parse (linha[0]),
                    texto: linha[1],
                    dataCriacao: System.DateTime.Parse(linha[2]),
                    usuario: linha[3],
                    aprovacao: bool.Parse(linha[4]));
                lsComentarios.Add (comentario);
            }
            return lsComentarios;
        }
    }
}