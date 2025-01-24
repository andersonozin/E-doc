using System;

namespace NotaFiscalOrdemServico
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exibir uma mensagem de boas-vindas
            Console.WriteLine("Bem-vindo ao E-Doc!");
            Console.WriteLine("Por favor, insira os dados a seguir:");

            // Capturar dados do usuário
            Console.Write("Nome do Cliente: ");
            string nomeCliente = Console.ReadLine();

            Console.Write("CNPJ do Cliente: ");
            string cnpjCliente = Console.ReadLine();

            Console.Write("Endereço (Rua, Cidade, Bairro): ");
            string endereco = Console.ReadLine();

            Console.Write("Telefone do Cliente: ");
            string telefoneCliente = Console.ReadLine();

            Console.Write("Serviço Realizado ou Produto Vendido: ");
            string servicoProduto = Console.ReadLine();

            Console.Write("Valor do Serviço/Produto: R$ ");
            string valor = Console.ReadLine();

            Console.Write("Data do Serviço/Venda: ");
            string data = Console.ReadLine();

            Console.Write("Número do Orçamento: ");
            string numeroOrcamento = Console.ReadLine();

            Console.Write("Nome da Sua Empresa: ");
            string nomeEmpresa = Console.ReadLine();

            Console.Write("Telefone da Empresa: ");
            string telefoneEmpresa = Console.ReadLine();

            Console.Write("Data de vencimento: ");
            string datavencimento = Console.ReadLine();

            // Mostrar os dados na tela
            Console.WriteLine("\nResumo dos Dados Inseridos:");
            Console.WriteLine($"Cliente: {nomeCliente}");
            Console.WriteLine($"CNPJ: {cnpjCliente}");
            Console.WriteLine($"Endereço: {endereco}");
            Console.WriteLine($"Telefone do Cliente: {telefoneCliente}");
            Console.WriteLine($"Serviço/Produto: {servicoProduto}");
            Console.WriteLine($"Valor: R$ {valor}");
            Console.WriteLine($"Data: {data}");
            Console.WriteLine($"Número do Orçamento: {numeroOrcamento}");
            Console.WriteLine($"Empresa: {nomeEmpresa}");
            Console.WriteLine($"Telefone da Empresa: {telefoneEmpresa}");
            Console.WriteLine($"Data de Vencimento: {datavencimento}");

            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
