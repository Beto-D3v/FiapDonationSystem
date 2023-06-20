namespace FiapDonationSystem
{
    public static class Program
    {
        public static void Main (string[] args)
        {
            Console.WriteLine("FIAP DONATION SYSTEM");

            Console.WriteLine("Preencha os dados cadastrais abaixo: ");

            Console.WriteLine("Digite o nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o seu telefone: \n");
            string telefone = Console.ReadLine();

            Console.WriteLine("Digite o seu e-mail: \n");
            string email = Console.ReadLine();

            Console.WriteLine("Digite a sua senha: \n");
            string senha = Console.ReadLine();

            Console.WriteLine("Digite o seu apelido: \n");
            string apelido = Console.ReadLine();
        }
    }
}