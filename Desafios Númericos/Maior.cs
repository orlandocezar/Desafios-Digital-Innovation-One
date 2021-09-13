using System;

namespace Bootcamp {
    class Program {
        static void Main(string[] args) {


            string[] vet = Console.ReadLine().Split(' ');
            int a = int.Parse(vet[0]);
            int b = int.Parse(vet[1]);
            int c = int.Parse(vet[2]);
            //complete declarando as variáveis


            int MAIORAB = (a + b + Math.Abs(a - b)) / 2;

            if (MAIORAB > c) {
                Console.WriteLine($"{MAIORAB} eh o maior");
            } else {
                Console.WriteLine($"{c} eh o maior");
            }





        }
    }
}
