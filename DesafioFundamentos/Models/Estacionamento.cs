namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            //Solicita que o usuário digite a placa do veículo estacionado e armazena ela na lista
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placaAdcionada = Console.ReadLine();
            veiculos.Add(placaAdcionada);
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Solicita que o usuário digite a placa do veículo que será removido
            string placaRemovida = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placaRemovida.ToUpper()))
            {
                //Pergunta a quantidade de horas que o veículo ficou estacionado e realzia o cálculo 
                //para retornar o valor a ser pago
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int horasEstacionado = Convert.ToInt32(Console.ReadLine());
                decimal valorTotal = precoInicial + precoPorHora * horasEstacionado;

                //Remove a placa da lista
                veiculos.Remove(placaRemovida);

                Console.WriteLine($"O veículo {placaRemovida} foi removido e o preço total foi de: {valorTotal:C}");
            }
            //Caso o usuário insira uma placa não cadastrada.
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                //Laço de repetição responsável por exibir as placas cadastradas
                for (int contador = 0; contador<veiculos.Count; contador++)
                {
                    string placaExibicao = veiculos[contador];
                    Console.WriteLine($"Placa do {contador+1}º veículo: {placaExibicao}");
                }
            }
            //Caso não tenha nenhum veículo cadastrado
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
