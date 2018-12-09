using Projeto_final_semestre_2018.Repositorios;

namespace Projeto_final_semestre_2018.Util
{
    public class Validacao
    {
        public static bool ValidarEmail(string email){
            //Verifica se o e-mail possui @ e .
            if(email.Contains("@") && email.Contains(".")){
                return true;
            }

            return false;
        }
        public static bool ValidarUsuario(string email, string senha){
            if (email.Contains("@checkpoint.org") && senha.Contains("admin"))
            {
                return true;
            }
            return false;
        }
        public static bool ValidarTexto (string texto){
            if (string.IsNullOrEmpty(texto) == true)
            {
                return false;
            } else
            {
                return true;
            }

        }
        public static bool ValidarSenha (string senha, string senhaVerificacao){
            if (senha == senhaVerificacao)
            {
                return true;
            } else{
                return false;
            }
        }
        //  public bool EmailValido(string email, List<Usuario> database)
        // {
        //     foreach (Usuario item in database)
        //     {
        //         if(item.Email == email){
        //             return false;
        //         }
        //     }
        //     return true;
        // }
    }
}