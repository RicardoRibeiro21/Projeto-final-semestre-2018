using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Senai.OO.ProjetoFinal.Interface;
using Senai.OO.ProjetoFinal.Models;
using Senai.OO.ProjetoFinal.Repositorio;

namespace Senai.OO.ProjetoFinal.Repositorios {
    public class ComentarioRepSerealizado : IComentario {
        public List<ComentarioModel> ComentariosSalvos { get; private set; }
        private const string caminho = "comentarios.dat";

        public ComentarioRepSerealizado () {
            if (File.Exists (caminho)) {
                ComentariosSalvos = Listar ();
            } else {
                ComentariosSalvos = new List<ComentarioModel> ();
                Salvar ();
            }
        }
        public void Aprovar (int id) {
            int item = CaçarId (id);
            if (!ComentariosSalvos[item].Aprovacao) {
                ComentariosSalvos[item].Aprovacao = true;
            Salvar ();
            }
        }
        public void Reprovar (int id) {
            int item = CaçarId (id);
            if (ComentariosSalvos[item].Aprovacao) {
                ComentariosSalvos[item].Aprovacao = false;
            Salvar ();
            }
        }

        public List<ComentarioModel> ComentariosAprovados () {
            List<ComentarioModel> ComentariosAceitos = new List<ComentarioModel> ();
            foreach (ComentarioModel comentario in ComentariosSalvos) {
                if (comentario.Aprovacao) {
                    ComentariosAceitos.Add (comentario);
                    Salvar ();
                }
            }
            return ComentariosAceitos;
        }

        public List<ComentarioModel> Listar () {
            //Ler os bytes que estão gravados no comentarios.dat
            byte[] bytesSerealizados = File.ReadAllBytes (caminho);
            //Desserealizar
            BinaryFormatter serealizador = new BinaryFormatter ();
            //passa os bytes para o memorystream
            MemoryStream memoria = new MemoryStream (bytesSerealizados);
            //Converter implicitamente  
            return (List<ComentarioModel>) serealizador.Deserialize (memoria);
        }
        public ComentarioModel Cadastrar (ComentarioModel comentario) {
            comentario.Id = ComentariosSalvos.Count + 1;
            ComentariosSalvos.Add (comentario);
            Salvar ();
            return comentario;
        }
        public ComentarioModel Procurar (int id) {
            foreach (ComentarioModel item in Listar ()) {
                if (item.Id == id) {
                    return item;
                }
            }
            return null;
        }
        public int CaçarId (int id) {
            int contador = 0;
            foreach (ComentarioModel item in ComentariosSalvos) {
                if (item.Id > 0)
                {
                if (item.Id == id) {
                    return contador;
                }
                contador++;
                    
                }
            }   
            return 0;
        }
        public void Salvar () {
            //Realizando a serealização
            MemoryStream memoria = new MemoryStream ();
            BinaryFormatter serealizador = new BinaryFormatter ();
            //Serealiza os UsuariosSalvos e guarda os dados dentro do MemoryStream
            serealizador.Serialize (memoria, ComentariosSalvos);
            //converter ou escrever em bytes primeiro parametro: nome do arquivo e segundo: pegar o objeto que tem os bytes.
            File.WriteAllBytes (caminho, memoria.ToArray ());
            ComentariosSalvos = Listar ();
        }
    }
}