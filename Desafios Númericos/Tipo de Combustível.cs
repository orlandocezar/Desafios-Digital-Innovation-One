using System;

namespace Desafios {

    /*
     Você recebeu desafio para determinar qual dos produtos é o preferêncial dos clientes de um posto de abastecimento de combustível. Para isso você deve escrever um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel 4.Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até que seja válido). O programa será encerrado quando o código informado for o número 4.
     */

    class Program {
        static void Main(string[] args) {
            int gasolina = 0, alcool = 0, diesel = 0;
            int TIPO;

            do {

                TIPO = Convert.ToInt32(Console.ReadLine());

                switch (TIPO) {
                    case 1:
                        gasolina += 1;
                        break;
                    case 2:
                        alcool += 1;
                        break;
                    case 3:
                        diesel += 1;
                        break;
                    case 4:
                        break;
                    default:
                        continue;
                }
            }

            while (TIPO != 4);

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine($"Alcool: {gasolina}");
            Console.WriteLine($"Gasolina: {alcool}");
            Console.WriteLine($"Diesel: {diesel}");
        }
    }
}
