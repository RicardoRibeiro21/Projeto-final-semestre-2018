using System;
using System.Collections.Generic;
using System.IO;
using Senai.OO.ProjetoFinal.Interface;
using Senai.OO.ProjetoFinal.Models;

namespace Projeto_final_semestre_2018.Repositorios {
    public class UsuarioRepositorio : IUsuario {
        

        public UsuarioViewModel Cadastrar (UsuarioViewModel usuario) {
            if (File.Exists ("usuarios.csv")) {
                //se o arquivo existir, pegar os dados e escrever na próxima linha
                usuario.Id = File.ReadAllLines ("usuarios.csv").Length + 1;
            } else {
                usuario.Id = 1;
            }
            using (StreamWriter sw = new StreamWriter ("usuarios.csv", true)) {
                sw.WriteLine ($"{usuario.Id};{usuario.Nome};{usuario.Email};{usuario.Senha};{usuario.Tipo}");
            }
            return usuario;
        }

        public UsuarioViewModel Editar (UsuarioViewModel usuario) {
            //Método extra
            throw new System.NotImplementedException ();

        }
        public void Excluir (int id) {
            //método extra
        }

        public UsuarioViewModel FazerLogin (string email, string senha) {
            using (StreamReader sr = new StreamReader ("usuarios.csv")) {
                while (!sr.EndOfStream) {
                    var linha = sr.ReadLine ();

                    if (string.IsNullOrEmpty (linha)) {
                        continue;
                    }
                    string[] dados = linha.Split (";");

                    if (dados[2] == email && dados[3] == senha) {
                        UsuarioViewModel usuario = new UsuarioViewModel (id: int.Parse (dados[0]),
                            nome: dados[1],
                            email: dados[2],
                            senha: dados[3],
                            tipo: dados[4]
                        );
                        return usuario;
                    };
                }

            }
            return null;
        }

    }
}