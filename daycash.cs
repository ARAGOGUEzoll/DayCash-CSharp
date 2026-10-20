using System;

namespace DayCash
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // array para cria novas senhas e logins         
           int[] password = new int[3];
            string[] name = new string[3];

            // login ja criado de administradores
            string adminname = "megumin";
            int adminpassword = 2323;

            // inicio do programa
            Console.WriteLine("Bem vindo usuario, voce e um novo usuario? (s/n)");
            string repostaone = Console.ReadLine();

            // criando login e senha
            if(repostaone == "s")
            {
                createlogin:
                Console.WriteLine("vamos cria um usuario primeiro crie seu login:");
                name[0] = Console.ReadLine();

                  // vendo se o login ja existe ou se e o mesmo do administrador  
                if(name[0] == "" || name[0] == null || name[0] == adminname)
                {
                    Console.WriteLine("Desculpe, nao foi possivel cria seu login tente novamente");
                    goto createlogin;
                }
                else
                {
                    createpassword:
                    Console.WriteLine("Agora vamos cria uma senha");
                    int.TryParse(Console.ReadLine(), out password[0]);

                    // vendo se a senha ja existe ou se e a mesma do administrador
                    if(password[0] == 0 || password[0] == adminpassword)
                {
                    Console.WriteLine("Desculpe, nao foi possivel cria seu login tente novamente");
                    goto createpassword;
                }
                }
                
            }
            // login e senha ja criados 
            else if(repostaone == "n")
            {
                Console.WriteLine("Certo entao vamos fazer o login");
                Trylogin:
                Console.WriteLine("Digite seu login:");
                string repostatwo = Console.ReadLine();
                
                    //login certa
                if (repostatwo == adminname || repostatwo == name[0])
                {
                    Console.WriteLine("Login aceito.");
                }
                // login errado
                else if (repostatwo != adminname || repostatwo != name[0])
                {
                    Console.WriteLine("Login incorreto, tente novamente");
                    goto Trylogin;
                }
                Console.WriteLine("Digite sua senha:");
                int.TryParse(Console.ReadLine(), out int repostathree);
                // senha certa
                if (repostathree == adminpassword || repostathree == password[0])
                {
                    Console.WriteLine("Senha aceita.");
                }
                // senha errada
                else if (repostathree != adminpassword || repostathree != password[0])
                {
                    Console.WriteLine("Senha incorreta, tente novamente");
                    goto Trylogin;
                }
            }
        }
    }
}
