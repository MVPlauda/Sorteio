internal class Program 
{
    private static void Main(string[] args) 
    {
        // Cria uma nova instância de Random para gerar um valor aleatório
        Random rnd = new Random();

        // Gera um valor aleatório entre 1 e 50 e armazena na variável valorSistema
        int valorSistema = rnd.Next(1, 50);

        Console.WriteLine("Adivinhe o número entre 1 e 50: ");
        int valorUsuario = int.Parse(Console.ReadLine());

        // Verifica se o valor digitado pelo usuário é igual ao valor gerado pelo sistema
        if (valorUsuario == valorSistema)
        {
            Console.WriteLine("Parabéns! Você acertou o número: " + valorSistema);
        }
        // Verifica se o valor digitado pelo usuário é menor que o valor gerado pelo sistema
        else if (valorUsuario < valorSistema)
        {
            Console.WriteLine("Errou! Deveria ter digitado um valor maior.");
        }
        // Se o valor digitado pelo usuário não for igual e nem menor que o valor gerado pelo sistema, então só pode ser maior
        
        else
        {
            Console.WriteLine("Errou! Deveria ter digitado um valor menor.");
        }
    }
}
