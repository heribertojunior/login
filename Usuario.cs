using System;
namespace login
{
    public class Usuario:ILogin
    {
        String usuario;
        String senha;

        public Usuario(String usuario,String senha)
        {
            this.usuario = usuario;
            this.senha = senha;
        }

        public void deslogar(int status)
        {
            if(status == 1){
                Console.WriteLine("Deslogando");
            }
        }

        public void logar()
        {
            Console.WriteLine("Bem vindo ");
        }
    }
}
