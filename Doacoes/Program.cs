namespace Doacoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantidadeDoacoes, i, quantidadeProjetos;
            double valorDoado, valorTotalDoacoes = 0, mediaDoacoes;
            Console.WriteLine("Informe o número de doações recebidas no mês: ");
            quantidadeDoacoes = Convert.ToInt32(Console.ReadLine());    

            for(i = 1; i <= quantidadeDoacoes; i++)
            {
                Console.WriteLine($"Informe o valor da {i}º doação recebida");
                valorDoado = Convert.ToDouble(Console.ReadLine());
                valorTotalDoacoes += valorDoado;
            }

            if(valorTotalDoacoes > 10000)
            {
                Console.WriteLine("Parabéns, o valor foi significativo");
            }
            else
            {
                Console.WriteLine("O valor precisa melhorar!");
            }

            Console.WriteLine("Informe a quantidade de projetos realizados no mês: ");

            quantidadeProjetos = Convert.ToInt32(Console.ReadLine());

            if(quantidadeProjetos >= 3)
            {
                Console.WriteLine("A ONG está realizando um excelente trabalho! Parabéns a toda a equipe!");
            }

            else
            {
                Console.WriteLine("É importante mais projetos para impactar ainda mais vidas.");
            }

            mediaDoacoes = valorTotalDoacoes / quantidadeProjetos;

            Console.WriteLine("Média de doações por projeto foi de {0}", mediaDoacoes.ToString("0.00"));

            Console.WriteLine("Quantidade de doações recebidas: " + quantidadeDoacoes);
            
            Console.WriteLine("Valor total das doações recebidas foi de R$: {0}", valorTotalDoacoes.ToString("0.00"));

            Console.WriteLine("Obrigado por contribuir com a nossa ONG!");
        }
    }
}