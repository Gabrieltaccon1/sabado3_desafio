using System;

namespace exercicio_sabado
{
    class Program
    {
        static void Main(string[] args)
        {
            carro veiculo = new carro("Ferrari", "458" ,"Italia");


            Console.WriteLine($"Marca:{veiculo.marca} \nModelo:{veiculo.modelo} \nPais de Origem:\n{veiculo.paisdeOrigem}\nQuantidade de Portas: {veiculo.qtdPortas()}\n" +
                $"Flex ? :{veiculo.Flex()} \nCapacidade Tanque de Combustivel: {veiculo.capacidadeTanque()}  \nSeu gasto de Combustivel é: {veiculo.gastocombustivel()} Litros\nA autonomia por litro é de :{veiculo.autonomiaporLitro()}");
        }
    }
}
