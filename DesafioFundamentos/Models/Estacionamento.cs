// Define o namespace do projeto
namespace DesafioFundamentos.Models
{
    // Classe que representa o estacionamento
    public class Estacionamento
    {
        // Variável para armazenar o preço inicial cobrado
        private decimal precoInicial = 0;

        // Variável para armazenar o preço por hora
        private decimal precoPorHora = 0;

        // Lista para armazenar as placas dos veículos estacionados
        private List<string> veiculos = new List<string>();

        // Construtor que recebe o preço inicial e o preço por hora
        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        // Método para adicionar um veículo ao estacionamento
        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine().ToUpper(); // Lê a placa e converte para maiúsculas

            veiculos.Add(placa); // Adiciona a placa à lista de veículos
            Console.WriteLine($"Veículo {placa} estacionado com sucesso.");
        }

        // Método para remover um veículo do estacionamento
        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine().ToUpper(); // Lê a placa e converte para maiúsculas

            // Verifica se o veículo está na lista
            if (veiculos.Any(x => x.ToUpper() == placa))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int horas = int.Parse(Console.ReadLine()); // Lê a quantidade de horas

                // Calcula o valor total a pagar
                decimal valorTotal = precoInicial + precoPorHora * horas;

                veiculos.Remove(placa); // Remove o veículo da lista

                // Exibe o valor total a pagar
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal:F2}");
            }
            else
            {
                // Caso a placa não esteja na lista
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente.");
            }
        }

        // Método para listar todos os veículos estacionados
        public void ListarVeiculos()
        {
            // Verifica se há veículos na lista
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (string placa in veiculos)
                {
                    Console.WriteLine(placa); // Exibe cada placa
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados."); // Mensagem caso a lista esteja vazia
            }
        }
    }
}
