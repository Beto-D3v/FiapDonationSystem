namespace FiapDonationSystem
{
    public static class Program
    {
        public static void Main (string[] args)
        {
            string nome, telefone, email, senha, apelido;

            Console.WriteLine("FIAP DONATION SYSTEM");

            //Criar um menu
            Console.WriteLine("\n1 - Registrar um novo usuário \n2 - Logar \n3 - Sair " + "Digite a opção desejada \n");

            int opcao = Convert.ToInt32(Console.ReadLine());

            if(opcao == 1) //Registrar novo usuário
            {
                Console.WriteLine("Preencha os dados cadastrais abaixo: ");

                Console.WriteLine("Digite o nome: ");
                nome = Console.ReadLine();

                Console.WriteLine("Digite o seu telefone: ");
                telefone = Console.ReadLine();

                Console.WriteLine("Digite o seu e-mail: ");
                email = Console.ReadLine();

                Console.WriteLine("Digite a sua senha: ");
                senha = Console.ReadLine();

                Console.WriteLine("Digite o seu apelido: ");
                apelido = Console.ReadLine();
            }
            else if(opcao == 2) //Logar
            {
                //email cadastrado = admin@fiap.com
                //senha cadastrada = admin123
                Console.WriteLine("Digite o seu e-mail: ");
                string emailLogin = Console.ReadLine();
                Console.WriteLine("Digite a sua senha: ");
                string senhaLogin = Console.ReadLine();

                if (emailLogin.Equals("admin@fiap.com")) //Recomendado
                {
                    if (senhaLogin.Equals("admin123"))
                    {
                        Console.WriteLine("Bem vindo ao sistema " + emailLogin);
                    }
                    else
                    {
                        Console.WriteLine("Usuário e/ou senha inválidos!");
                    }
                }

                else 
                {
                        Console.WriteLine("Usuário e/ou senha inválidos!");
                }

            }
            else
            {
                Console.WriteLine("Obrigado por utilizar o nosso programa!");
            }
            
        }
    }
}