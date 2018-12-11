using System.IO;
using Projeto_final_semestre_2018.Repositorios;
using Senai.OO.ProjetoFinal.Models;
using Senai.OO.ProjetoFinal.Repositorios;

namespace Projeto_final_semestre_2018.Util {
    public class Validacao {
        public static bool ValidarEmail (string email) {
            //Verifica se o e-mail possui @ e .
            if (email.Contains ("@") && email.Contains (".")) {
                return true;
            }

            return false;
        }
        public static bool BuscarPorEmail(string email)
        {
             using (StreamReader sr = new StreamReader ("usuarios.csv")) {
                while (!sr.EndOfStream) {
                    var linha = sr.ReadLine ();

                    if (string.IsNullOrEmpty (linha)) {
                        continue;
                    }
                    string[] dados = linha.Split (";");

                    if (dados[3] == email) {
                     return true;
                    };
                }
            }
            return false;
        }
        public static bool ValidarUsuario (string email, string senha) {
            if (email.Contains ("@carfel.org") && senha.Contains ("admin")) {
                return true;
            }
            return false;
        }
        public static bool ValidarTexto (string texto) {
            if (string.IsNullOrEmpty (texto) == true) {
                return false;
            } else {
                return true;
            }

        }
        public static bool ValidarSenha (string senha, string senhaVerificacao) {
            if (senha == senhaVerificacao) {
                if (senha.Length < 4) {
                return false;
                }
                return true;

            } else {
                return false;
            }
        }
    }
}