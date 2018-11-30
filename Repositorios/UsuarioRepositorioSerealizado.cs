using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Senai.OO.ProjetoFinal.Interface;
using Senai.OO.ProjetoFinal.Models;

namespace Senai.OO.ProjetoFinal.Repositorios {
    public class UsuarioRepositorioSerealizado : IUsuario {
        public List<UsuarioViewModel> usuariosSalvos { get; private set; }

        public UsuarioRepositorioSerealizado () {
            if (File.Exists ("usuarios.dat")) {
                usuariosSalvos = Listar ();
            } else {
                usuariosSalvos = new List<UsuarioViewModel> ();
            }
        }
        public List<UsuarioViewModel> Listar () {
            if (!File.Exists ("usuarios.dat")) {
                return new List<UsuarioViewModel> ();
            }
            //Ler os bytes que estão gravados no usuarios.dat
            byte[] bytesSerealizados = File.ReadAllBytes ("usuarios.dat");
            //Desserealizar
            BinaryFormatter serealizador = new BinaryFormatter ();
            //passa os bytes para o memorystream
            MemoryStream memoria = new MemoryStream (bytesSerealizados);
            //Converter implicitamente  
            return (List<UsuarioViewModel>) serealizador.Deserialize (memoria);
        }
        private void SerealizarLista () {
            //Realizando a serealização
            MemoryStream memoria = new MemoryStream ();
            BinaryFormatter serealizador = new BinaryFormatter ();
            //Serealiza os UsuariosSalvos e guarda os dados dentro do MemoryStream
            serealizador.Serialize (memoria, usuariosSalvos);

            //converter ou escrever em bytes primeiro parametro: nome do arquivo e segundo: pegar o objeto que tem os bytes.
            File.WriteAllBytes ("usuarios.dat", memoria.ToArray ());
        }

        //Serealizando o usuario cadastrado
        public UsuarioViewModel Cadastrar (UsuarioViewModel usuario) {
            usuario.Id = usuariosSalvos.Count + 1;
            usuariosSalvos.Add (usuario);
            return usuario;

        }

        public UsuarioViewModel Editar (UsuarioViewModel usuario) {
            throw new System.NotImplementedException ();
        }

        public void Excluir (int id) {
            throw new System.NotImplementedException ();
        }

        public UsuarioViewModel FazerLogin (string email, string senha) {
            foreach (var usuario in usuariosSalvos) {
                if (email == usuario.Email && senha == usuario.Senha) {
                    return usuario;
                }
            }
            return null;
        }

        public UsuarioViewModel BuscarPorId (int id) {
            throw new System.NotImplementedException ();
        }

    }
}