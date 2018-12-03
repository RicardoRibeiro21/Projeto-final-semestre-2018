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
            if (email.Contains("@checkpoint.org") && senha.Contains("admin") )
            {
                return true;
            }
            return false;
        }
    }
}