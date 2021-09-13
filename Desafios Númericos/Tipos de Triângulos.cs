using System;

namespace Bootcamp {
    class Program {
        static void Main(string[] args) {


            string[] s = Console.ReadLine().Split(' ');
            double a = double.Parse(s[0]);
            double b = double.Parse(s[1]);
            double c = double.Parse(s[2]);
            double x;

            if (a < b) { x = a; a = b; b = x; }
            if (b < c) { x = b; b = c; c = x; }
            if (a < b) { x = a; a = b; b = x; }

            if (a >= b + c)
                Console.WriteLine("NAO FORMA TRIANGULO");
            else if (a * a == b * b + c * c)
                Console.WriteLine("TRIANGULO RETANGULO");
            else if (a * a > b * b + c * c)
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            else if (a * a < b * b + c * c)
                Console.WriteLine("TRIANGULO ACUTANGULO");
            if (a == b && b == c)
                Console.WriteLine("TRIANGULO EQUILATERO");
            else
              if (a == b || b == c) Console.WriteLine("TRIANGULO ISOSCELES\n");

            Console.ReadLine();
        }



    }
}

